namespace FsUnit.Test
open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``be choice tests`` ()=
    [<Test>] member test.
     ``Choice1Of2 should be the first choice`` ()=
        Choice<int,int>.Choice1Of2(1) |> should be (choice 1)
    [<Test>] member test.
     ``Choice1Of3 should be the first choice`` ()=
        Choice<int,int,int>.Choice1Of3(1) |> should be (choice 1)
    [<Test>] member test.
     ``Choice1Of4 should be the first choice`` ()=
        Choice<int,int,int,int>.Choice1Of4(1) |> should be (choice 1)
    [<Test>] member test.
     ``Choice1Of5 should be the first choice`` ()=
        Choice<int,int,int,int,int>.Choice1Of5(1) |> should be (choice 1)
    [<Test>] member test.
     ``Choice1Of6 should be the first choice`` ()=
        Choice<int,int,int,int,int,int>.Choice1Of6(1) |> should be (choice 1)
    [<Test>] member test.
     ``Choice1Of7 should be the first choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice1Of7(1) |> should be (choice 1)

    [<Test>] member test.
     ``Choice2Of2 should be the second choice`` ()=
        Choice<int,int>.Choice2Of2(1) |> should be (choice 2)
    [<Test>] member test.
     ``Choice2Of3 should be the second choice`` ()=
        Choice<int,int,int>.Choice2Of3(1) |> should be (choice 2)
    [<Test>] member test.
     ``Choice2Of4 should be the second choice`` ()=
        Choice<int,int,int,int>.Choice2Of4(1) |> should be (choice 2)
    [<Test>] member test.
     ``Choice2Of5 should be the second choice`` ()=
        Choice<int,int,int,int,int>.Choice2Of5(1) |> should be (choice 2)
    [<Test>] member test.
     ``Choice2Of6 should be the second choice`` ()=
        Choice<int,int,int,int,int,int>.Choice2Of6(1) |> should be (choice 2)
    [<Test>] member test.
     ``Choice2Of7 should be the second choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice2Of7(1) |> should be (choice 2)

    [<Test>] member test.
     ``Choice3Of3 should be the third choice`` ()=
        Choice<int,int,int>.Choice3Of3(1) |> should be (choice 3)
    [<Test>] member test.
     ``Choice3Of4 should be the third choice`` ()=
        Choice<int,int,int,int>.Choice3Of4(1) |> should be (choice 3)
    [<Test>] member test.
     ``Choice3Of5 should be the third choice`` ()=
        Choice<int,int,int,int,int>.Choice3Of5(1) |> should be (choice 3)
    [<Test>] member test.
     ``Choice3Of6 should be the third choice`` ()=
        Choice<int,int,int,int,int,int>.Choice3Of6(1) |> should be (choice 3)
    [<Test>] member test.
     ``Choice3Of7 should be the third choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice3Of7(1) |> should be (choice 3)

    [<Test>] member test.
     ``Choice4Of4 should be the fourth choice`` ()=
        Choice<int,int,int,int>.Choice4Of4(1) |> should be (choice 4)
    [<Test>] member test.
     ``Choice4Of5 should be the fourth choice`` ()=
        Choice<int,int,int,int,int>.Choice4Of5(1) |> should be (choice 4)
    [<Test>] member test.
     ``Choice4Of6 should be the fourth choice`` ()=
        Choice<int,int,int,int,int,int>.Choice4Of6(1) |> should be (choice 4)
    [<Test>] member test.
     ``Choice4Of7 should be the fourth choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice4Of7(1) |> should be (choice 4)

    [<Test>] member test.
     ``Choice5Of5 should be the fifth choice`` ()=
        Choice<int,int,int,int,int>.Choice5Of5(1) |> should be (choice 5)
    [<Test>] member test.
     ``Choice5Of6 should be the fifth choice`` ()=
        Choice<int,int,int,int,int,int>.Choice5Of6(1) |> should be (choice 5)
    [<Test>] member test.
     ``Choice5Of7 should be the fifth choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice5Of7(1) |> should be (choice 5)

    [<Test>] member test.
     ``Choice6Of6 should be the sixth choice`` ()=
        Choice<int,int,int,int,int,int>.Choice6Of6(1) |> should be (choice 6)
    [<Test>] member test.
     ``Choice6Of7 should be the sixth choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice6Of7(1) |> should be (choice 6)

    [<Test>] member test.
     ``Choice7Of7 should be the seventh choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice7Of7(1) |> should be (choice 7)

    [<Test>] member test.
     ``Choice1Of2 should not be the second choice`` ()=
        Choice<int,int>.Choice1Of2(1) |> should not' (be choice 2)
    [<Test>] member test.
     ``Choice2Of3 should not be the third choice`` ()=
        Choice<int,int,int>.Choice2Of3(1) |> should not' (be choice 3)
    [<Test>] member test.
     ``Choice3Of4 should not be the fourth choice`` ()=
        Choice<int,int,int,int>.Choice3Of4(1) |> should not' (be choice 4)
    [<Test>] member test.
     ``Choice4Of5 should not be the fifth choice`` ()=
        Choice<int,int,int,int,int>.Choice4Of5(1) |> should not' (be choice 5)
    [<Test>] member test.
     ``Choice5Of6 should not be the fifth choice`` ()=
        Choice<int,int,int,int,int,int>.Choice5Of6(1) |> should not' (be choice 6)
    [<Test>] member test.
     ``Choice6Of7 should not be the seventh choice`` ()=
        Choice<int,int,int,int,int,int,int>.Choice6Of7(1) |> should not' (be choice 7)
     
