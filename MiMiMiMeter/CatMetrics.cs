using System.Drawing;

namespace MiMiMiMeter
{
    public class CatMetrics
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Upvotes { get; set; }
        public Image Image { get; private set; }
        public bool Chosen { get; set; }
        public bool Shown { get; set; }

        public CatMetrics(int id, string name, int upvotes, Image image)
        {
            Id = id;
            Name = name;
            Upvotes = upvotes;
            Image = image;
            Chosen = Shown = false;
        }

        public override string ToString() => $"{Name} - {Upvotes} Лайков";
    }
}
