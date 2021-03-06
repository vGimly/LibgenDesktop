﻿using System;
using LibgenDesktop.Models.Utils;

namespace LibgenDesktop.Models.Entities
{
    internal class SciMagArticle : LibgenObject
    {
        private string doiString;

        public SciMagArticle()
        {
            doiString = null;
        }

        public string Doi { get; set; }
        public string Doi2 { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Volume { get; set; }
        public string Issue { get; set; }
        public string FirstPage { get; set; }
        public string LastPage { get; set; }
        public string Journal { get; set; }
        public string Isbn { get; set; }
        public string Issnp { get; set; }
        public string Issne { get; set; }
        public string Md5Hash { get; set; }
        public long SizeInBytes { get; set; }
        public DateTime? AddedDateTime { get; set; }
        public string JournalId { get; set; }
        public string AbstractUrl { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public string Attribute6 { get; set; }
        public string Visible { get; set; }
        public string PubmedId { get; set; }
        public string Pmc { get; set; }
        public string Pii { get; set; }

        public string FileSizeString => Formatters.FileSizeToString(SizeInBytes, false);
        public string FileSizeWithBytesString => Formatters.FileSizeToString(SizeInBytes, true);
        public string AddedDateTimeString => AddedDateTime != null ? AddedDateTime.Value.ToString("dd.MM.yyyy HH:mm:ss") : "неизвестно";

        public string DoiString
        {
            get
            {
                if (doiString == null)
                {
                    if (!String.IsNullOrWhiteSpace(Doi))
                    {
                        doiString = Doi;
                    }
                    if (!String.IsNullOrWhiteSpace(Doi2))
                    {
                        if (doiString.Length > 0)
                        {
                            doiString += "; ";
                        }
                        doiString += Doi2;
                    }
                }
                return doiString;
            }
        }

        public string PagesString
        {
            get
            {
                if ((!String.IsNullOrWhiteSpace(FirstPage) && FirstPage != "0") || (!String.IsNullOrWhiteSpace(LastPage) && LastPage != "0"))
                {
                    string firstPage = FirstPage != "0" ? FirstPage.Trim() + " " : String.Empty;
                    string lastPage = LastPage != "0" ? " " + LastPage.Trim() : String.Empty;
                    return firstPage + "–" + lastPage;
                }
                else
                {
                    return "неизвестно";
                }
            }
        }
    }
}
