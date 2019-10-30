# Starter for java (JUnit5)

Minimal setup with Java [JUnit5](https://junit.org/junit5/) to get you started.
You can use [gradle](https://gradle.org/) or [maven](https://maven.apache.org/)

* java 8+ (testded with openjdk 11.0.2)
* maven 3.6+ or included mvnw
* gradle 5.6+ or included gradlew

---
**NOTE**

If you don't have maven or gradle don't install them, simply use included project wrapper (**mvnw** , **gradlew**).

---


## Before workshop

Clone this project (or export) to your computer.

Test all is ok (Using maven) **prefered** :

```mvn test``` or for linux users ```./mvnw test``` or for windows users ```mvnw.cmd test```.

![mvn test : Tests run: 3, Failures: 1, Errors: 0, Skipped: 0](/java/mvn-test.gif)

Test all is ok (Using gradle) :

```gradle test``` or for linux users ```./gradlew test``` or for windows users ```gradlew.bat test```.

![gradle test : 3 tests completed, 1 failed](/java/gradlew-test.gif)

Have fun!
