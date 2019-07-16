# Kentico EMS Component Starter
[![Build status](https://ci.appveyor.com/api/projects/status/st73cvjh2vr7r0ck?svg=true)](https://ci.appveyor.com/project/kentico/ems-mvc-component-starter/branch/master)

This is a starter point to develop MVC Page Builder Components. It contains one sample widget, inline editor, form component and section.

## Components development best practices
* [Widgets](https://docs.kentico.com/k12sp/developing-websites/page-builder-development/developing-widgets-in-mvc)
* [Sections](https://docs.kentico.com/k12sp/developing-websites/page-builder-development/developing-page-builder-sections)
* [Form components](https://docs.kentico.com/k12sp/developing-websites/form-builder-development/developing-form-components)
* [Inline editors](https://docs.kentico.com/k12sp/developing-websites/page-builder-development/developing-widgets-in-mvc/creating-inline-editors-for-widget-properties)
* [Personalization condition types](https://docs.kentico.com/k12sp/on-line-marketing-features/configuring-and-customizing-your-on-line-marketing-features/content-personalization-on-mvc-sites/developing-personalization-condition-types)

## Get started

1. **Download Kentico installation**
    * [`Kentico_12_0_trial.exe` Trial](https://www.kentico.com/download-demo/trial-version)
1. **Install Kentico** using [the command line](https://docs.kentico.com/k12sp/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration#Commandlineinstallation-XMLconfiguration-SQL).
    * Use [Kentico installation profile](/KenticoInstallationProfile.xml) template and define `TargetFolder` attribute of the `IIS` tag (:warning: Do not use the same location as the one you have you exe file located)
      ```sh
      .\Kentico_12_0_trial.exe KenticoInstallationProfile.xml
      ```
        * This will install Kentico Administration interface without any site
        * If you wish to adjust the connection to the different database server, [adjust the `SQL` tag in the configuration XML](https://docs.kentico.com/k12sp/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration#Commandlineinstallation-XMLconfiguration-SQL)
        * If you wish to add your license to the instance, [adjust the `Licenses` tag in the configuration XML](https://docs.kentico.com/k12sp/installation/installing-kentico-from-the-command-line/command-line-installation-xml-configuration#Commandlineinstallation-XMLconfiguration-Licenses)

    * If you get an error about already installed program files run command for uninstalling the current program files and then run the previous command again

      ```sh
      .\Kentico_12_0_trial.exe /u
      ```

1. **Apply the latest [hotfix](https://devnet.kentico.com/download/hotfixes)** (or at least 12.0.29)

1. Run the administration instance (already registered in IIS with `_Admin` suffix) **and import [the site export package](/SandboxSite.zip)** according to the [documentation](https://docs.kentico.com/K12SP/Importing+a+site+or+objects)
    * This package contains
        * Site (With `Presentation URL`)
        * Page type (configured for page builder - url pattern `/` and use tab  checkbox)
        * Page by this page type
        * Automatic web farms

1. **Clone this repository** to the different folder than the Kentico administration is installed

    ```sh
    git clone https://github.com/Kentico/ems-mvc-component-starter
    ```

1. Rename [`AppSettings.config.template`](/SandboxSite/AppSettings.config.template) to `AppSettings.config` and put the **hash string salt** (`CMSHashStringSalt`) there from Kentico administration application `web.config` application settings.

1. Rename [`ConnectionStrings.config.template`](/SandboxSite/ConnectionStrings.config.template) to `ConnectionStrings.config` and put the **connection string** (`CMSConnectionString`) there from Kentico administration application `web.config` connection strings.

1. Build the [`MVCComponentStarter.sln`](/MVCComponentStarter.sln).

1. Download and install latest [NodeJS runtime](https://nodejs.org/en/)

1. Navigate to root of this project using console and install missing npm packages
    ```sh
    npm install
    ```
1. After installing npm packages start DEV server for serving transpiled JavaScript files
    ```sh
    npm run dev
    ```

1. Press F5 in Visual Studio to start application using IIS express

1. Open the administration interface, go to Pages, select the `Home` and you could see the **page builder set up**.

![Starter showcase](/Starter.png)

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/ems-mvc-component-boilerplate?pixel)
