using LinQQuires.SimpleQuery;


GettinStartedQuery.GetLengthOfNamedQuery();


string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
IEnumerable<string> sortedByLength, sortedAlphabetically;
sortedByLength = names.OrderBy(n => n.Length); // int key
sortedAlphabetically = names.OrderBy(n => n);

//The Take operator outputs the first x elements, discarding the rest
int[] numbers = { 10, 9, 8, 7, 6 };
IEnumerable<int> firstThree = numbers.Take(3); // { 10, 9, 8 }
// The Skip operator ignores the first x elements and outputs the rest:
IEnumerable<int> lastTwo = numbers.Skip(3); // { 7, 6 }
// Reverse does exactly as it says:
IEnumerable<int> reversed = numbers.Reverse(); // { 6, 7, 8, 9, 10 }


int firstNumber = numbers.First(); // 10
int lastNumber = numbers.Last(); // 6
int secondNumber = numbers.ElementAt(1); // 9
int secondLowest = numbers.OrderBy(n => n).Skip(1).First(); // 7

int count = numbers.Count(); // 5;
int min = numbers.Min(); // 6;
bool hasTheNumberNine = numbers.Contains(9); // true
bool hasMoreThanZeroElements = numbers.Any(); // true
bool hasAnOddElement = numbers.Any(n => n % 2 != 0); // true

int[] seq1 = { 1, 2, 3 };
int[] seq2 = { 3, 4, 5 };
IEnumerable<int> concat = seq1.Concat(seq2); // { 1, 2, 3, 3, 4, 5 }
IEnumerable<int> union = seq1.Union(seq2); // { 1, 2, 3, 4, 5 }