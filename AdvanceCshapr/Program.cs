﻿

using AdvanceCshapr.Delegates;

CalculationDelegateClass delC = new CalculationDelegateClass();

Transformer trans = delC.sum;
//Transformers trans = delC.sum;
Transformer tran = delC.Multiply;
//Console.WriteLine(trans.Invoke(6));
//Console.WriteLine(tran.Invoke(5));
var values = new int[] { 3, 4, 5, 6, 7, 8 };

 //delC.Transform(values, trans);
 delC.Transform(values, tran);


//foreach (var v in values) Console.WriteLine(v);


Transformer del = delC.sum;
del += delC.Multiply;

Console.WriteLine(del.Invoke(5));

