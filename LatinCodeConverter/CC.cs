using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

namespace net.uyghurdev.Text
{
    #region Properties
    /// <summary>
    /// Code Converter
    /// <para>Author:Sarwan</para>
    /// </summary>
    public class CodeConvert
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Descraption;

        public string Descraption
        {
            get { return _Descraption; }
            set { _Descraption = value; }
        }
        private string _Author;

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        Dictionary<char, char> Chars;
        Dictionary<string, string> CompoundChars;
        Dictionary<string, string> Replacment;
    #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFileName"></param>
        public CodeConvert(string strFileName)
        {
            Chars = new Dictionary<char, char>();
            CompoundChars = new Dictionary<string, string>();
            Replacment = new Dictionary<string, string>();
            Chars.Clear();
            CompoundChars.Clear();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            System.IO.TextReader tr = new System.IO.StringReader(strFileName); ;


            XmlReader reader = XmlReader.Create(tr, settings);
            reader.Read();
           
            while (reader.Read())
            {
                if ((reader.Name == "CodeConvert") && (reader.IsStartElement()))
                {
                    Name = reader.GetAttribute("Name");
                    Descraption = reader.GetAttribute("Descraption");
                    Author = reader.GetAttribute("Author");
                }
                else if ((reader.Name.ToLower() == "code") && (reader.IsStartElement()))
                {
                    if (reader.GetAttribute("isCompound").ToLower() == "true")
                    {
                        CompoundChars.Add(reader.GetAttribute("SourceCode"), reader.GetAttribute("ReplaceCode"));
                    }
                    else if (reader.GetAttribute("isCompound").ToLower() == "false")
                    {
                        Chars.Add(Convert.ToChar(reader.GetAttribute("SourceCode")),Convert.ToChar( reader.GetAttribute("ReplaceCode")));
                    }
                }
                else if ((reader.Name.ToLower() == "replace") && (reader.IsStartElement()))
                {
                    Replacment.Add(reader.GetAttribute("Regex"), reader.GetAttribute("Replacement"));
                }
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSource"></param>
        /// <returns></returns>
        public string ToConvert(string strSource)
        {
            string strResult = strSource;
           
            foreach (string str in CompoundChars.Keys)
            {
                strResult=strResult.Replace(str, CompoundChars[str]);
            }

            StringBuilder sb = new StringBuilder();
            foreach (char chr in strResult.ToCharArray())
            {
                if (Chars.ContainsKey(chr))
                {
                    sb.Append(Chars[chr]);
                }
                else
                {
                    sb.Append(chr);
                }
            }
             string strRet=sb.ToString();
            foreach (string str in Replacment.Keys)
            {
                strRet = Regex.Replace(strRet, str, Replacment[str]);
            }
            return strRet;
        } 
    }
}
