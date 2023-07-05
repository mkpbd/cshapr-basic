using LinQQuires.SimpleQuery;


GettinStartedQuery.GetLengthOfNamedQuery();


string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
IEnumerable<string> sortedByLength, sortedAlphabetically;
sortedByLength = names.OrderBy(n => n.Length); // int key
sortedAlphabetically = names.OrderBy(n => n);