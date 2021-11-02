module Sum.Tests

open System
open NUnit.Framework
open Sum 

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.TestSum() =
        let actual = Sum.sum 1 4
        Assert.That(actual, Is.EqualTo(5))

