﻿using System;
/*
 * Exactly the same as Element.java, hopefully they work exaclty the same too.
 */
namespace CSC240_WCFMS04
{
    abstract class Element
    {
        public string getClassName()
        {
            string resultStr;
            int beginAt;

            resultStr = this.ToString();
            beginAt = resultStr.IndexOf('.');

            return resultStr.Substring(beginAt + 1);
        }

        public abstract void readIn();

        public abstract void display();

        public abstract Element clone();

        public abstract string toString();
    }
}
