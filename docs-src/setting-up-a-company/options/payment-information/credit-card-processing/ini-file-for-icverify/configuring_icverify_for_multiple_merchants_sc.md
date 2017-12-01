---
title: Configuring ICVerify for Multiple Merchants
---

# Configuring ICVerify for Multiple Merchants


ICVerify has a multi-user version that supports multiple  merchant accounts. The bank authorizing your credit card is referred to  as a merchant bank. Businesses use multiple merchant accounts when they  have more than a single location to process/authorize credit cards and  each location has a different dial-up account to the bank for requesting  approvals. This section details the configurations required for using  ICVerify with multiple merchant accounts.


Prerequisites


You must work with ICVerify and get multiple merchants installed.


ICVerify Configurations


{:.steps}
To configure ICVerify for Multiple Merchants,  do the following:

- ICVerify uses .SET  files for configuring their merchant accounts. In other words, if you  have two merchants, the ICVerify files would look like ICVERIFY.SET and  ICVE0001.SET.

ICVERIFY.SET is the default file and is required to open up the IC  Verify Setup screen.

If you have two merchants then you need to make sure that the set files  are listed as: 

ICVERIFY.SET
ICVE0001.SET
ICVE0002.SET

By default you would see the first two set files only. 

In order to add the third file, just copy and paste ICVERIFY.SET and  make a copy of the file. Then rename the file to ICVE0002.SET.



![]({{site.sc_baseurl}}/img/icverify_mm_set_files_sc.jpg)


**Figure: ICVerify .SET Files for Multiple Merchants**

- Log in to **ICVerify** and select **Edit**  > **Options**.



![]({{site.sc_baseurl}}/img/icverify_mm_edit_options_sc.jpg)


**Figure: ICVerify Edit > Options**

- Click the **Merchants Table** button.
- Click the Merchant  Name listed on the left and see what the Merchant Code on the right is  (0001).
- Click the **Add Merchant** button and define the merchant  code as 0002.



![]({{site.sc_baseurl}}/img/icverify_mm_merchants_table_sc.jpg)


**Figure: ICVerify Merchants Table**

- Click **OK**.
- To verify if both  of the merchant accounts are working correctly, from the main screen select  **Function** > **Switch 
 Merchants** and that should list both the merchants and allow you  to switch.



Creating the INI file


The most critical factor in configuring the INI file for  multiple merchants is the CLERK field. This field should be hard coded  in the INI file exactly the way it is shown in the following figure.


![]({{site.sc_baseurl}}/img/icverify_mm_configure_ini_sc.jpg)


**Figure: Creating the INI file for Multiple Merchants**


Configure the INI file


See the [Configuration File for  ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html) section for INI configuration information.


![]({{site.sc_baseurl}}/img/see_also.gif)
: [Configuration  File for ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
