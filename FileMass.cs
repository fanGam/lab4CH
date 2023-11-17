using System.Xml.Serialization;

namespace lab4CH
{
    [Serializable]
    public class FileMass
    {
        private int[] Mass;
        private Random rnd = new Random();
        int n;
        public int[] Arr
        {
            get { return Mass; }
        }
        public int Len
        {
            get { return n; }
        }
        public FileMass()
        {
            n = 100;
            Mass = new int[100];
            for (int i = 0; i < n; i++)
            {
                Mass[i] = rnd.Next(0, 100);
            }
            
        }
        public FileMass(int a)
        {
            n = a;
            Mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Mass[i] = rnd.Next(0, 100);
            }
            XmlSerializer xml = new XmlSerializer(typeof(FileMass));
            FileStream f = new FileStream("File.xml", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            xml.Serialize(f, this);
        }
    }
}
