Splunk MINT allows you to gain mobile intelligence about your mobile apps by using the Splunk MINT SDKs with your existing mobile app projects. Then, you can use Splunk MINT Management Console to monitor and gain insights into all of your mobile apps. 

*Splunk®, Splunk>®, Splunk MINT are trademarks of Splunk Inc., in the United States and other countries.  Xamarin is a trademark of Xamarin Inc.*

The Splunk MINT Software Development Kit for Xamarin iOS is licensed under the Apache License 2.0. Details can be found in the LICENSE file.

##Introduction##

In addition to sending crash reports, you can send additional data to Splunk MINT to monitor specific actions and items in your mobile apps.

* **Monitor transactions**. Track any process in your app from start to finish and identify slow transactions that negatively affect the user experience.
* **Add and report events**.  Add events to your code and report them to track virtually any user activity on your app.
* **Report handled exceptions**. Log handled exceptions that occur, along with any custom information you want to add. 
* **Add custom data and breadcrumbs to crash reports**. Add custom data to your crash reports as key-value pairs. You can also add breadcrumbs to your code to tag events or actions, which are also included in crash reports.
* **Report user-specific data**. Track the experience of any given user by adding user identifiers to your code, then you can search for errors that affected a particular user and examine the corresponding crash data.
* **Send log output**. Collect and view system debug messages depending on the platform. For example, send LogCat output from Android devices or NSLog messages from iOS devices.
* **Report debug messages**. Display debug messages during testing before you deploy to production.

Mobile apps that use the Splunk MINT SDKs send data to the MINT Data Collector, which then sends the data to Splunk MINT Management Console.

**How to monitor your mobile apps with Splunk MINT**

1. Download a Splunk MINT SDK or plugin for a platform that your app runs on, then import the SDK or plugin into your mobile app project.

2. [Log in to Splunk MINT Management Console](https://mint.splunk.com/dashboard) and create a project for your app. You'll get an API key for the project and a line of code to add for that particular platform&mdash;copy it to your clipboard.

3. Paste this line of code containing your project API key into your app to integrate MINT (for details, see the platform-specific sections in this guide).

    When you start using your app, it will begin to send data to the Splunk MINT Data Collector.

4. Go back to MINT Management Console and open your project. You'll start to see data appear in your dashboards in minutes.

    Repeat this procedure for each of the platforms your app runs on. After you've set up your projects in MINT Management Console, you can use the Splunk MINT App in Splunk&reg; Enterprise to see aggregated data for all of your mobile app projects over all time.


**Documentation**

* For more information about Splunk MINT, see the [Splunk MINT Overview](http://docs.splunk.com/Documentation/Mint/latest/ProductOverview/AboutSplunkMINT). 