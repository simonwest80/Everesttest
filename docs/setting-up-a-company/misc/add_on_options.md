---
title: Integrated Options
---

# Integrated Options


**CRM Studio**
: CRM Studio is enabled in the sample company only  for a period of 30 days. If you purchase CRM Studio and Multiple Companies  option, you can use CRM Studio on any of the companies you create as part  of the Multiple Companies option.


**eStorefront**
: You can create additional shops in **Everest**  from the **E-Commerce Preferences**  browser/profile (path: **File** >  **Setup** > **E-Commerce**  > **Preferences** > **E-Commerce 
 Preferences**). There are no restrictions with creating the e-commerce  preferences for a company. You can create multiple websites using the  Shop Administrator, and register the websites (using the Register option)  with IIS to make them available online.
: The eStorefront activation key determines the number  of active websites allowed. This does not limit the number of websites  you can create, but only limits the number of websites you can have actively  running live. **Everest eStorefront**  includes one website.  If  you purchase two additional websites, you can use these three websites  on any company or a combination of companies. In this case, the total  number of websites that you can publish online cannot exceed three.
: One license is necessary for each **E-Commerce 
 Preference** (shop) used in a web store registered in the Shop Administrator.  Use the following formula to determine the number of website licenses  required:
: # of licenses = # of live registered websites  with different E-Commerce Preferences


{:.example}
Using **E-Commerce Preferences**,  create three sets of preferences (shops) in Everest: Default, Shop1 and  Shop2. Create four websites in the Shop Administrator.  In  the Shop Settings, select “Default” for Website1 and Website2. Select  “Shop1” for Website3 and “Shop2” for Website4.


| **E-Commerce  Preference (Shop)** | **Licenses Needed** | **Registered Websites in the Shop Administrator** |
| Default | 1 | Website1 |
| Default | Website2 |
| Shop1 | 1 | Website3 |
| Shop2 | 1 | Website4 |

: Notice that only one license is required for using  the “Default” E-Commerce Preference even if there are multiple websites.  You can use a singe E-Commerce Preference (shop) by multiple registered  live websites without increasing the number of licenses required.
: In this situation, three licenses are required.  One license is required for Website1 and Website2, one license is required  for Website3, and another one is required for Website4.
: **Everest**  checks for distinct connections that are open for the above shops in the  E-Commerce Preferences.
: In the above scenario, if you only had two website  licenses, you could register one of the following combinations of websites  in the Shop Administrator:

- Website1 and Website3
- Website1, Website2  and Website3
- Website2 and Website3
- Website1 and Website4
- Website1, Website2  and Website4
- Website2 and Website4
- Website3 and Website4

: Website1 and Website2 can both be viewed at one  point of time along with any other website.  The restriction is based on the number of **distinct 
 connections**.
: You can create any number of web shops and register  them. But, at any given point of time, a maximum of three websites can  actively run in the Accel Sample Company.
: If no option key is defined, the eStorefront option  displays one website  in the **License Details** column.
: In case of **multiple 
 companies**, the licenses are validated against all shops across  all companies.


{:.example}
If you create two companies and have three websites licensed, you can  set up the websites as below:


**Example A**


2 websites on Company one


1 website  on Company two


**Example B**


1 website  on Company one


2 websites on Company two


**Example C**


0 websites on Company one


3 websites on Company two


{:.note}
If the distinct shop connections exceed the licensed  number, you are not allowed to log in or connect to the database.


In that case, **Everest**  displays an error message on the website  stating that the system has exceeded the limits set by the software license  in connection with multiple websites.


**PageBoost**
: To activate the PageBoost  functionality, you first need to activate the eStorefront functionality.  PageBoost is intended for **Everest Legacy 
 E-Commerce**.


**Point of Sale**
: This option is activated for 5 users in the sample  company and during the evaluation period.
: When the number of user licenses for POS is exceeded  and a user tries to login,  **Everest** will prompt you with the  message "The number of users that simultaneously access Point of  Sale registers cannot exceed XXX  user(s) for this license".


{:.example}
You have a 50 user **Everest**  license with a 30 user Point of Sale license. This means you can log into  only 30 cash registers at the same time. If more users try to login,  they will be prompted with the message.


**MailBridge**
: You require an activation key to run MailBridge  on your machine.


**US Payroll**
: This integrated feature is not available in the  evaluation mode.


**Gift Card**
: A Gift Card license is not a user-based license.  Only one license is required for processing gift cards for your entire  company. The Gift Card feature is available in the Sample Company and  in evaluation mode.
: When Gift Card is not licensed:

- Gift Card activation  will display the error message ‘Gift Card is not licensed’ if you try  to sell a gift card item.
- Gift Card redemption  will display the error message ‘Gift Card is not licensed’ if you try  to redeem a gift card item.
- The Gift Card  check box is disabled in **Item**  profile.
- The Gift Card  Balance Inquiry option is disabled in the Utility, Point of Sale and Sales  Invoice profiles.
- When you try  to save a Gift Card payment method, the error message ‘Gift Card is not  licensed’ is displayed.



**Everest Inventory Planning**
: This option takes the pain and guesswork out of  inventory management. The **Everest Inventory 
 Planning Wizard** utility automatically calculates minimum, maximum,  and reorder quantities based on your items’ sales/purchase histories and  settings that you configure including usage quantity, lead time, and safety  stock. It allows you to classify items according to the quantity on hand,  profitability, cost, and price. The **Everest 
 Inventory Planning Wizard** utility even has special considerations  for seasonal items along with your regular items. This improves the efficiency  of your Purchasing staff by eliminating the need to export sales data,  analyze it, and then re-import it to set replenishment points.


**Everest Mobile Warehouse**
: This option allows you to use a handheld **Everest 
 Mobile Warehouse** device to move freely around the warehouse when  receiving items or picking items to ship without being tied to a desk.  Most tasks can be completed quickly using the built-in scanner.


**DataBridge**
: This option comprises the following functionalities:

- Data Import
- Third Party  Catalog Import
- Sales Order  Import

: All the above features are enabled when you purchase  the license from Everest Software. These features are not available in  the evaluation mode.


**Multiple Companies**
: Use the Multiple Companies option to license more  than one company inside **Everest**  with a single set of registration information. If you purchase this option,  there is no limit on the number of companies you can create in **Everest**.  All the companies will use the same user pool. If you have a 10-user license  and three companies, you can have users in each company as below:
: Three users in company One
: Five users in company Two
: Two users in company Three
: All the three companies will be working off the  same user license count and you can log in to the companies in any combination  you want as long as you do not exceed the user count of your license.
: The Multiple Companies option for the company you  have registered with Everest Software must be activated to use the same  serial number for subsidiary companies. When you create a company and  try to activate it, **Everest** checks  if the database server has other companies with the same serial number.  If it finds a matching company, **Everest**  informs you that the serial number specified is already used for the parent  company XXX,  which has the Multiple Companies option activated. The fields for the  activation codes in the new company are disabled and no data is available.  You can activate the company by accepting the confirmation for using the  Multiple Companies license for subsidiary companies.


**Software Development Kit**
: To further enhance the power of **Everest**,  **Everest Software** provides an **Everest Software Development Kit** **(SDK)** for developers, contractors, and  value-added resellers (VARs). **Everest 
 SDK** supports the development of custom-fit, practical solutions  without requiring in-depth knowledge of **Everest's**  architecture. SDK programs use the regular architecture for **Everest**  transactions. **Everest SDK** contains  the following components:

- **Everest 
 API** - Allows programmatic access and integrates with Everest Business  Objects
- **EDM 
 Case Tool** - Contains supporting documentation used to integrate  with the Everest Database
- **Everest 
 Forms Designer** - Allows customization of the layout and design  of Everest forms
- **Everest 
 Add-Ins** - Allows programs to integrate with the Everest Client



**Forms Designer**
: Use the **Forms Designer**  utility to design customized profile data entry screens. You can improve  the look and feel of the profiles according to your business needs. You  can also enhance security by limiting end user access in the profile.  The Forms Designer moves customization control away from the end user  to the System Administrator or another individual authorized to design  forms.
: The customized views that are created can be assigned  to specific users or groups of users. In this way, your existing and new  end users can be set up quickly and easily. These customizations can give  your end users a more favorable software experience and increase their  productivity at the same time.


**Everest Advanced Dashboard**
: The **Everest Advanced 
 Dashboard** adds an advanced business intelligence feature to your  desktop. Business Intelligence technologies allow in-depth analysis of  your company's data and transactions after they occur for better decision-making.  Your System Administrator, or other authorized user, uses the **Everest**  data warehouse **Setup** to create  a data warehouse from your **Everest**  database. This data warehouse contains important data collected from your  business through **Everest**.  Selected  information is provided to you, based on business requirements, and is  displayed in chart or graphic format on your **Everest 
 Advanced Dashboard**.  These  blocks of information provided to you are called **Web 
 Parts**.
: In **Everest**,  the **Everest Advanced Dashboard**  can replace the **Everest** desktop.  The **Everest Advanced Dashboard**  is also available as a web page that can be accessed remotely. The **Everest Advanced Dashboard** uses the  power of **Everest's** data integration  to provide you with necessary information used for:

- : Searching and  reporting
- : Performance  metrics
- : Monitoring  key performance indicators for improvements
- : Advanced analysis  and more informed decision-making
- : Understanding  your customers' needs
- : Increasing  customer satisfaction
- : Prospecting  new customers
- : Gaining a competitive  advantage

: The **Everest Advanced 
 Dashboard** gives you the ability to see mission critical information  that is relevant to you. The **Everest 
 Advanced Dashboard** can include graphs, reports, performance indicators,  and reminders on the dashboard depending upon how it has been configured.
: ![]({{site.sc_baseurl}}/img/lens.gif)[Dashboard  Analytics]({{site.sc_baseurl}}/misc/dashboard_analytics_sc.html)


{:.see_also}
See also
: [Company  Setup Profile - Activation - Options tab]({{site.sc_baseurl}}/misc/everest_registration_option_activation_tab.html)
: [Hardware Key]({{site.sc_baseurl}}/misc/protection_key.html)
