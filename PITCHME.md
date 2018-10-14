@title[Cover]

@snap[north-west byline]
  Software Development Series
@snapend

@snap[west headline text-white]
  @size[0.75em](@color[orange](T)est @color[orange](D)riven @color[orange](D)evelopment)  
  @size[0.75em](in .NET Core) C#  
@snapend

---

@title[Earth without TDD]

@snap[west headline text-white]
  @size[0.75em](What Would Earth Be Like @color[brown](Without TDD) ?)
@snapend

+++

@title[Mysteries]

![img](assets/img/other_peoples_code.png)

+++

@title[Code Quality]

![img](assets/img/code_quality.png)

+++

@title[Misunderstanding]

![img](assets/img/requirement.png)

---

@title[TDD Definition]

## [Wikipedia](https://en.wikipedia.org/wiki/Test-driven_development)

@size[0.75em](@fa[quote-left] Test-driven development is a software development process that relies on the repetition of a very short development cycle: @color[orange](requirements are turned into very specific test cases, then the software is improved to pass the new tests, only). This is opposed to software development that allows software to be added that is not proven to meet requirements @fa[quote-right])

---

@title[Requirements to Test cases]

@snap[west headline text-white]
  @size[0.75em](Turn Requirements)  
  @color[orange](@fa[angle-double-right] Test cases)
@snapend

+++

@title[Grouping]

@snap[north headline]
Grouping
@snapend

@snap[midpoint list-content-concise span-100]
@ol
- Normal cases
- Alternative cases
- Exception cases
@olend
@snapend

+++

@title[Example]

## Example

```
Normal cases
1.ผู้ใช้กดเงินออกจากตู้ข้อมูลถูกต้อง ระบบทำการหักเงินแล้วนำเงินออกมา
2.ผู้ใช้กดเงินออกจากตู้แต่เงินในบัญชีไม่พอ ระบบทำการแจ้งเตือน
3.ผู้ใช้กดเงินออกจากตู้ข้อมูลถูกต้อง แต่ตู้มีเงินไม่พอจ่าย ระบบทำการแจ้งเตือน

Alternative cases
4.ผู้ใช้บัญชีพิเศษกดเงินมากกว่าที่มีในบัญชี ระบบบันทึกเครดิตแล้วนำเงินออกมา
5.ผู้ใช้บัญชีพิเศษกดเงินมากกว่าที่มีในบัญชี แต่เครดิตเต็มแล้ว ระบบทำการแจ้งเตือน

Exception cases
6.ผู้ใช้ถอนเงินสำเร็จแต่ระบบไม่สามารถตัดเงินออกจากบัญชีได้ ระบบทำการแจ้งเตือน
```
@[1-4](Normal cases: กรณีที่เจอได้บ่อยๆ 80~90%)
@[6-8](Alternative cases: กรณีที่นานๆจะเกิดขึ้นที หรือเคสขอบ)
@[10-11](Exception cases: กรณีข้อผิดพลาดที่ยอมรับไม่ได้)

---

@title[Test cases to Testable code]

@snap[west headline text-white]
  @size[0.75em](Turn Test cases)  
  @color[orange](@fa[angle-double-right] Testable code)
@snapend

+++?image=assets/img/bg/orange.jpg&position=right&size=50% 100%

@title[xUnit]

@snap[west split-screen-heading span-50]
[xUnit Framework](https://xunit.github.io)  
![img](assets/img/xunit.png)
@snapend

@snap[east text-white span-50]
@ol[split-screen-list](false)
- Install [.NET Core SDK](https://www.microsoft.com/net/download)
- Open Command Prompt
- Type the cmd below
@size[0.5em](dotnet new xunit -n demoexunit)
@snapend

+++

@title[Fact & Theory]

### Fact & Theory Attributes

```
[Fact]
public void TestMethod1()
{
    // Do something
}

[Theory]
[InlineData(1)]
[InlineData(9)]
public void TestMethod2(int input)
{
    // Do something
}
```
@[1-2](Fact Attribute: ใช้ทดสอบสิ่งที่เป็นจริงเสมอ และ method นั้นจะรับ parameters ไม่ได้)
@[7-10](Theory Attribute: ใช้ทดสอบ test cases หลายๆแบบ และ method สามารถมี parameters ได้)

+++

@title[Demo]

@snap[west headline]
  @size[1.5em](@color[orange](@fa[laptop]) Demo)  
  ATM's scenarios
@snapend

---

@title[TDD Mantra]

@snap[west split-screen-heading span-60]
@size[0.75em](The Mantra of TDD)  
![img](assets/img/tdd_mantra.png)
@snapend

@snap[east text-white span-40 fragment]
@ol[split-screen-list](false)
@size[0.5em](@fa[quote-left] TDD is a software development process which consists of writing unit test that will **initially fail** and then implementing minimum amount of code to **pass** that test to @color[yellow](**avoiding over engineer**) @fa[quote-right])
@snapend

---

@title[TDD vs Traditional Testing]

### TDD vs Traditional Testing

||TDD|Traditional|
|--|--|--|
|Strategy|Test First|Code First|
|Code covered with tests|> 90%|@fa[question]|
|When to write tests|Now|@fa[question]|
|Short term|@fa[angle-double-down]|@fa[rocket]|
|Long term|@fa[rocket]|@fa[angle-double-down]|

---

@title[Refactoring]

@snap[west split-screen-heading span-60]
Refactoring  
![img](assets/img/tdd_mantra.png)
@snapend

@snap[east text-white span-40]
@ol[split-screen-list]
* Is the existing design the best design possible?
* If not, refactor the code until it is easier to add new feature
<div class="fragment">@color[orange](@fa[question-circle] We have a lot of work to do!! Can we skip it?)</div>
@snapend

---

@title[Enterprise App Development]

## Enterprise App Development

+++?image=assets/img/bg/orange.jpg&position=right&size=50% 100%

@title[App's Concerns]

@snap[west split-screen-heading span-50]
App's Concerns
@snapend

@snap[east text-white span-50]
@ol[split-screen-list](false)
* Maintainable code
* Sharable code
* Scalable 
@fa[question-circle] None-functional requirements
@snapend

+++?image=assets/img/bg/orange.jpg&position=right&size=50% 100%

@title[None-Functional Requirements]

@snap[west split-screen-heading span-50]
@size[0.75em](None-Functional Requirements)
@snapend

@snap[east text-white span-50]
@ol[split-screen-list](false)
* Scalable
* Security
* Privacy
* Readability
@snapend

+++

@title[Who writes the tests?]

@snap[west headline text-white]
  @size[0.75em](Who writes the tests?)  
  @color[brown](@fa[heartbeat] The whole TEAM)
@snapend

---

@title[Types of Software Testing]

### Types of Software Testing

1. Non-functional testing
1. Functional testing

+++?image=assets/img/bg/orange.jpg&position=right&size=50% 100%

@title[Non-functional testing types]

@snap[west split-screen-heading span-50]
@size[0.75em](Non-Functional)  
Testing  
Types
@snapend

@snap[east text-white span-50]
@ol[split-screen-list](false)
- Performance Testing
- Load testing
- Stress testing
- Volume testing
- Security testing
- Compatibility testing
- Install testing
- bla bla bla
@snapend

+++?image=assets/img/bg/orange.jpg&position=right&size=50% 100%

@title[Functional testing types]

@snap[west split-screen-heading span-50]
Functional  
Testing  
Types
@snapend

@snap[east text-white span-50]
@ol[split-screen-list](false)
* Unit testing
- Integration testing
- System testing
- Sanity testing
- Smoke testing
- Interface testing
- Regression testing
- Acceptance testing
@snapend

+++

@title[Unit Testing]

## Unit Testing

@fa[quote-left] A unit test is a piece of a code that invokes another piece of code (unit) and checks if output of that action is the same as desired output @fa[quote-right]

---

@title[Types of testing]

## Types of testing

1. Manual Testing
2. Test Automation

+++

@title[Manual Testing]

## Manual Testing
Manual testing is the process of manually testing software for defects. It requires a tester to play the role of an end user whereby they use most of the application's features to ensure correct behavior. To guarantee completeness of testing, the tester often follows a written test plan that leads them through a set of important test cases.

+++

@title[Test Automation]

## Test Automation
Test automation is the use of special software (separate from the software being tested) to control the execution of tests and the comparison of actual outcomes with predicted outcomes.

+++

@title[Manual vs Automation]

### Manual vs Automation

||Manual|Automation|
|--|--|--|
|Human error|@fa[check]|@fa[exclamation]|
|@fa[bitcoin]|@fa[angle-double-up]|@fa[angle-double-down]|
|@fa[bug]|@fa[check]|@fa[exclamation]|
|Time|@fa[angle-double-down]|@fa[rocket]|
|CI/CD|@fa[times]|@fa[check]|
---

@title[Implementing Automation Frameworks in .NET]

@snap[west headline text-white]
  @size[0.75em](Implementing Automation Frameworks in .NET)
@snapend

+++

@title[Frameworks]

## Frameworks
1. MSTest
1. NUnit
1. xUnit

+++

## AAA Pattern
|||
|--|--|
|Arrange|Describes the phase where we initialize everything we need to do in that test|
|Act|Call parts of the system that is tested|
|Assert|Check the result|

---

@title[Code Coverage]

## Code Coverage
1. Defines a degree to which the source code of a system under tests is executed when a particular test suit has been run (Usually expressed in percentage)
1. If code was not executed during the tests, then it is not tested
1. Meaning, bug can hide in that part of the code
1. 100% Not a Guarantee!

---

@title[Mocking Framework]

## Mocking Framework

@size[0.75em](@fa[quote-left] Mocking Framework. Isolate a portion of a system to test by imitating behavior of dependencies. When unit testing, you are often interested in testing a portion of a complete system isolated from dependencies. To test a portion of the system, we can use mock objects to replace the dependencies @fa[quote-right])

+++

@title[Moq Framework]

## [Moq](https://github.com/moq/moq4)

```
var mock = new Mock<ILoveThisFramework>();

mock.Setup(framework => framework.DownloadExists("2.0.0.0"))
    .Returns(true);

ILoveThisFramework lovable = mock.Object;
bool download = lovable.DownloadExists("2.0.0.0");

mock.Verify(framework => framework.DownloadExists("2.0.0.0"), Times.AtMostOnce());
```
@[1](Create mock object from Moq framework)
@[3-4](Setup its behavior)
@[6](Use the Object property on the mock to get a reference to the object)
@[7](exercise it by calling methods on it)
@[9](Verify that the given method was indeed called with the expected value at most once)

+++

@title[Demo Moq]

@snap[west headline]
  @size[1.5em](@color[orange](@fa[laptop]) Demo)  
  Moq Framework
@snapend

---

@title[S.O.L.I.D]

@snap[west headline text-white]
  @size[0.75em](Object Oriented Design)  
  @color[orange](S.O.L.I.D) Principles
@snapend

---?image=assets/img/bg/orange.jpg&position=right&size=50% 100%

@title[Summary]

@snap[west split-screen-heading span-50]
Summary
@snapend

@snap[east text-white span-50]
@ol[split-screen-list](false)
**Pros**
- Drive your code design
- Prevent bugs
- Validation & Verification
- Cost

**Cons**
- Time consumption
@snapend

---

@title[End]

@snap[west headline span-100]
Thank you ;)  
@snapend

@snap[south-west byline text-white]
@fa[comments] Leave your questions below
@snapend

@snap[south-east byline text-white]
@fa[graduation-cap] See all courses [@Saladpuk.com](http://www.saladpuk.com)
@snapend