using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite_pattern
{
    public interface ICategory
    {
        string Name { get; set; }
        bool IsRoot { get; set; }
        void Display();

    }
}
