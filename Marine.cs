using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCall
{
    internal class Marine
    {

    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Description
    {
        public string description { get; set; }
    }

    public class HigherClassificationMap
    {
        public string _1 { get; set; }
        public string _54 { get; set; }
        public string _367 { get; set; }
        public string _543 { get; set; }
        public string _3670 { get; set; }
        public string _197625319 { get; set; }
        public string _197625320 { get; set; }
        public string _197625321 { get; set; }
        public string _197625322 { get; set; }
        public string _197625333 { get; set; }
        public string _108 { get; set; }
        public string _345 { get; set; }
        public string _434 { get; set; }
        public string _44 { get; set; }
        public string _204 { get; set; }
        public string _708 { get; set; }
        public string _4512 { get; set; }
        public string _2337411 { get; set; }
        public string _199679309 { get; set; }
        public string _199679315 { get; set; }
        public string _199679320 { get; set; }
        public string _199679321 { get; set; }
        public string _199679328 { get; set; }
        public string _199679363 { get; set; }
        public string _199679331 { get; set; }
        public string _2344833 { get; set; }
        public string _2345086 { get; set; }
        public string _216 { get; set; }
        public string _1470 { get; set; }
        public string _5602 { get; set; }
        public string _1107205 { get; set; }
        public string _2338751 { get; set; }
        public string _199679337 { get; set; }
        public string _198639333 { get; set; }
        public string _198639334 { get; set; }
        public string _198639335 { get; set; }
        public string _198639348 { get; set; }
        public string _198639353 { get; set; }
        public string _198639355 { get; set; }
        public string _199849245 { get; set; }
        public string _199849246 { get; set; }
        public string _199849247 { get; set; }
        public string _199849263 { get; set; }
        public string _199849264 { get; set; }
        public string _2181275 { get; set; }
    }

    public class Result
    {
        public int key { get; set; }
        public int nameKey { get; set; }
        public string datasetKey { get; set; }
        public string constituentKey { get; set; }
        public int nubKey { get; set; }
        public int parentKey { get; set; }
        public string parent { get; set; }
        public string kingdom { get; set; }
        public string phylum { get; set; }
        public string order { get; set; }
        public string family { get; set; }
        public string genus { get; set; }
        public int kingdomKey { get; set; }
        public int phylumKey { get; set; }
        public int classKey { get; set; }
        public int orderKey { get; set; }
        public int familyKey { get; set; }
        public int genusKey { get; set; }
        public string scientificName { get; set; }
        public string canonicalName { get; set; }
        public string authorship { get; set; }
        public string publishedIn { get; set; }
        public string nameType { get; set; }
        public string taxonomicStatus { get; set; }
        public string rank { get; set; }
        public string origin { get; set; }
        public int numDescendants { get; set; }
        public int numOccurrences { get; set; }
        public bool extinct { get; set; }
        public List<string> habitats { get; set; }
        public List<object> nomenclaturalStatus { get; set; }
        public List<string> threatStatuses { get; set; }
        public List<Description> descriptions { get; set; }
        public List<object> vernacularNames { get; set; }
        public bool synonym { get; set; }
        public HigherClassificationMap higherClassificationMap { get; set; }
        public string @class { get; set; }
        public string species { get; set; }
        public int? speciesKey { get; set; }
        public int? basionymKey { get; set; }
        public string basionym { get; set; }
    }

    public class Root
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public bool endOfRecords { get; set; }
        public int count { get; set; }
        public List<Result> results { get; set; }
        public List<object> facets { get; set; }
    }


}
