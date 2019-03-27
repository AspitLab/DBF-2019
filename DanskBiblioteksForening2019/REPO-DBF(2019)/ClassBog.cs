﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    /// <summary>
    /// This Class Handles the fields and properties for each book.
    /// </summary>
    public class ClassBog
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ClassBog()
        {

        }
        //Private Fields holding values
        #region
        private int _id;
        private ClassISBN _isbnNr;
        private ClassTitle _titel;
        private ClassAuthor _forfatter;
        private ClassPublisher _forlag;
        private ClassGenre _genre;
        private ClassType _type;
        private decimal _pris;
        #endregion
        #region constructors
        public ClassBog(int inid,string inisbnNr,string intitel, string inforfatter,string inforlag,string ingenre,string intype,decimal inpris)
        {
            inid = id;
            inisbnNr = isbnNr;
            intitel = titel;
            inforfatter = forfatter;
            inforlag = forlag;
            ingenre = genre;
            intype = type;
            inpris = pris;
        }
        public ClassBog()
        {
            id = 0;
            isbnNr = "";
            titel = "";
            forfatter = "";
            forlag = "";
            genre = "";
            type = "";
            pris = 0;
        }
        #endregion
        #region Properties

        public int id
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    Notify("id");

                }
            }
        }   
        public ClassISBN isbnNr
        {
            get { return _isbnNr; }
            set
            {
                if (value != _isbnNr)
                {
                    _isbnNr = value;
                    Notify("isbnNr");

                }
            }
        }
        public ClassTitle titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public ClassAuthor forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }
        public ClassPublisher forlag
        {
            get { return _forlag; }
            set { _forlag = value; }
        }
        public ClassGenre genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public ClassType type
        {
            get { return _type; }
            set { _type = value; }
        }
        public decimal pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

    }
}
