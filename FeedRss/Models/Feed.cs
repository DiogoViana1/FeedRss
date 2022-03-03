﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace FeedRss.Models
{
   public class Feed{
        public string Title { get; set; }
        public DateTime PubDate { get; set; }
        public string Link { get; set; }
        public string Guid { get; set; }
        public string Author { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }


    }
}