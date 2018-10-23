using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void Button1_Click(object sender, EventArgs e)
        {
            animal bowser = new animal("bowser", 4, 25);
            Stream stream = File.Open("animal.dat", FileMode.Create);
            bf.Serialize(stream, bowser);
            stream.Close();
            bowser = null;
            stream = File.Open("animal.dat", FileMode.Open);
            bf = new BinaryFormatter(); 

            bowser = (animal)bf.Deserialize(stream);
            stream.Close();
            Label1.Text = bowser.ToString();
            bowser.Weight = 50;
            XmlSerializer serializer = new XmlSerializer(typeof(animal));
            using (TextWriter tw = new StreamWriter(@"C: \Users\c#serial\animals.xml"))
            {
                serializer.Serialize(tw, bowser);
            }
            bowser = null,
            XmlSerializer deserializer = new XmlSerializer(typeof(animal));
            TextReaderreader = new StreamReader(@"@C: \Users\c#serial\animals.xml)");
            object obj = deserializer.Deserialize(reader);
            bowser = (animal)obj;
            reader.Close)()


            Label1.Text = bowser.ToString();
        }
    }
}