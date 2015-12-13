using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Barcline.OpenEhr.Model
{
    // http://stackoverflow.com/questions/637933/how-to-serialize-a-timespan-to-xml
    public class XmlTimeSpan
    {
        private TimeSpan m_value = TimeSpan.Zero;

        public XmlTimeSpan() 
        { 
        }

        public XmlTimeSpan(TimeSpan source) 
        { 
            m_value = source; 
        }

        public static implicit operator TimeSpan?(XmlTimeSpan o)
        {
            return o == null ? default(TimeSpan?) : o.m_value;
        }

        public static implicit operator XmlTimeSpan(TimeSpan? o)
        {
            return o == null ? null : new XmlTimeSpan(o.Value);
        }

        public static implicit operator TimeSpan(XmlTimeSpan o)
        {
            return o == null ? default(TimeSpan) : o.m_value;
        }

        public static implicit operator XmlTimeSpan(TimeSpan o)
        {
            return o == default(TimeSpan) ? null : new XmlTimeSpan(o);
        }

        [XmlText]
        public String Default
        {
            get 
            { 
                return XmlConvert.ToString(m_value); 
            }
            set 
            { 
                m_value = XmlConvert.ToTimeSpan(value); 
            }
        }
    }
}
