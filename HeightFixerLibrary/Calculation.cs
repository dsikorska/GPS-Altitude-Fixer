using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using NETGeographicLib;

namespace HeightFixerLibrary
{
    public class Calculation
    {
        private Geoid geoid;
        private string[] splitline;
        private string latitude;
        private string longitude;

        #region ConvertProgressEvent
        public delegate void ConvertProgressHandler(int ProgressValue);
        public event ConvertProgressHandler ConvertProgressEvent;

        protected virtual void ConvertProgress(int ProgressValue)
        {
            if (ConvertProgressEvent != null)
            { 
                ConvertProgressEvent(ProgressValue);
            }
        }
        #endregion

        public void ConvertInitializer(ConverterModel model)
        {
            model.InputText = File.ReadAllLines(model.InputPath);
            model.OutputFile = new StreamWriter(model.OutputPath);
            model.NewText = new Dictionary<string, string>();
            geoid = new Geoid("egm2008-1", @"geoids", true, true);
        }

        public void Convert(ConverterModel model)
        {
            int lineNumber = 0;
            int lastCurrentProgress = 0;

            foreach (string line in model.InputText)
            {
                lineNumber++;
                int currentProgress = ((lineNumber*100) / model.InputText.Length);

                if (line.StartsWith("$GPGGA"))
                {
                    splitline = line.Split(',');
                    latitude = splitline[2].Substring(0, 9);
                    longitude = splitline[4].Substring(0, 10);
                    double heightDifference = Math.Round(geoid.Height(ConvertLatitudeToDecimal(latitude), ConvertLongitudeToDecimal(longitude)), 4);
                    double masl = double.Parse(splitline[9], CultureInfo.InvariantCulture); //metres above sea level
                    double maslCorrected = masl - heightDifference;
                    model.NewText[line] = line.Replace(masl.ToString(CultureInfo.InvariantCulture), maslCorrected.ToString(CultureInfo.InvariantCulture)).Remove(64, 3).Insert(64, heightDifference.ToString(CultureInfo.InvariantCulture));
                }

                if (currentProgress != lastCurrentProgress)
                {
                    ConvertProgress(currentProgress);
                    lastCurrentProgress = currentProgress;
                }
            }
        }

        //The method converts latitude from nmea to decimal format
        private double ConvertLatitudeToDecimal(string lat)
        {
            latitude = lat.Substring(0, 2);
            if (lat.Substring(2, 2) == "00")
            {
                latitude += ",00";
            }
            else if (lat.Substring(2, 1) == "0")
            {
                latitude += ",0";
            }
            else
            {
                latitude += ",";
            }
            latitude += double.Parse(lat.Substring(2, 2) + lat.Substring(5)) / 60;
            if ((double.Parse(lat.Substring(2, 2) + lat.Substring(5))) / 60 != 0)
            {
                latitude = latitude.Remove(latitude.LastIndexOf(','), 1);
            }
            return double.Parse(latitude);
        }

        //The method converts longitute from nmea to decimal format
        private double ConvertLongitudeToDecimal(string lon)
        {
            longitude = lon.Substring(0, 3);
            if (lon.Substring(3, 2) == "00")
            {
                longitude += ",00";
            }
            else if (lon.Substring(3, 1) == "0")
            {
                longitude += ",0";
            }
            else
            {
                longitude += ",";
            }
            longitude += double.Parse(lon.Substring(3, 2) + lon.Substring(6)) / 60;
            if ((double.Parse(lon.Substring(3, 2) + lon.Substring(6))) / 60 != 0)
            {
                longitude = longitude.Remove(longitude.LastIndexOf(','), 1);
            }
            return double.Parse(longitude);
        }

        public void WriteResult(ConverterModel model)
        {
            string bufor = "";
            int buforClearFrequency = 100;
            int buforState = 0;

            foreach (string line in model.InputText)
            {
                string thisLine = line;
                if (line.StartsWith("$GPGGA"))
                {
                    thisLine = thisLine.Replace(line, model.NewText[line]);
                }
                bufor += thisLine + "\r\n";

                if (buforState >= buforClearFrequency)
                {
                    model.OutputFile.Write(bufor);
                    bufor = "";
                    buforState = 0;
                }
                buforState++;
            }

            if (bufor.Length > 0)
            {
                model.OutputFile.Write(bufor);
                bufor = "";
            }
            model.OutputFile.Close();
        }
    }
}
