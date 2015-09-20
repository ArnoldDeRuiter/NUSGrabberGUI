namespace NUS_grabber_GUI
{
    class ComboboxItem
    {   
        public string Desc { get; set; }
        public object Title_ID { get; set; }
        public object Versions { get; set; }
        public object Region { get; set; }
        public override string ToString()
        {
            Desc = (Desc != null || Desc != "") ? Desc : "null";
            return Desc;
        }
    }
}
