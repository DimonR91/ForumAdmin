﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumController
{
    class PostExt : Post
    {
        string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
    }
}