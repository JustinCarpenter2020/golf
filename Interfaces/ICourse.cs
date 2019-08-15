using System.Collections.Generic;

namespace Golf.Interfaces
{
    public interface ICourse
    {
        //NOTE don't forget to create a Course model and then within this file declare `using Golf.Models`
        string Name { get; set; }
        List<Hole> Holes { get; set; }
    }
}