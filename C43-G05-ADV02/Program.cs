using System.Buffers.Text;
using System.Collections;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Xml;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C43_G05_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections in c#
            // Lists      => Generic - Non-Generic
            // Hashtables => Generic - Non-Generic

            //Generic - Non-Generic

            //Lists:    
            // Generic : List ,LinkedList , Stack , Queue
            //  Non-Generic : ArrayList , Stack , Queue


            //Hashtables:    
            // Generic : Dictionsary , SortedDictionary
            //  Non-Generic : Hashtables 


            // Collections:
            // are used to group objects, right? They're more flexible than arrays
            // because they can dynamically resize.

            // ----------------------

            // How exactly do they work in C#?

            //there's the System.Collections namespace, which includes non-generic collections like
            // ArrayList, Hashtable

            //  Then there's System.Collections.Generic for generics like
            //  List<T>, Dictionary<TKey, TValue>, which are type-safe

            // and System.Collections.Concurrent for thread-safe collections in multi-threaded scenarios.
            // Also, System.Collections.Immutable for immutable collections

            // ----------------------

            // Wait, what's the difference between non-generic and generic collections? 
            // The non-generic ones like ArrayList store objects,
            // so you can have any type, but that's not type-safe.
            // Generics enforce a specific type, so better for type safety and performance
            // since no boxing/unboxing

            // ----------------------

            // Types of Collections
            // a. System.Collections (Non-Generic)
            // b. System.Collections.Generic (Generic)
            // c. System.Collections.Concurrent (Thread-Safe)
            // d. System.Collections.Immutable (Immutable)

            // . Best Practices
            //Prefer Generics: Use List<T> instead of ArrayList for type safety and performance.

            // ----------------------

            //Choose the Right Collection:


            //Use Dictionary for fast key-based lookups.



            //Use List for ordered, indexable data.


            //Use HashSet for unique elements and set operations.


            //Thread Safety: Opt for Concurrent collections in multi - threaded code.


            //LINQ Integration: Leverage LINQ for querying(e.g., Where(), Select()).

            // ----------------------

            //When to Use Collections:

            //Dynamic Data: When the number of elements is unknown.

            //Key - Based Access: Use Dictionary for efficient lookups.


            //Ordered Processing: Use Queue or Stack for specific order requirements.

            //Thread - Safe Scenarios: Use Concurrent collections in parallel code.


        }
    }
}
