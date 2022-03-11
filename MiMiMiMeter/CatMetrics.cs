namespace MiMiMiMeter
{
    public class CatMetrics
    {
        public CatMetrics(int Id, string Name, int Upvotes, string Link)
        {
            this.Id = Id;
            this.Name = Name;
            this.Upvotes = Upvotes;
            this.Link = Link;
            Chosen = Shown = false;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Upvotes { get; set; }
        public string Link { get; private set; }
        public bool Chosen { get; set; }
        public bool Shown { get; set; }

        public override string ToString() => $"{Name} - {Upvotes} Лайков";
    }
}
