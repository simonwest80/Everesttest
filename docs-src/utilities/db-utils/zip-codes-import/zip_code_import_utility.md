---
title: Zip Code Import
---

# Zip Code Import


The **Zip/FIPS 
 Codes Import** utility updates the existing ZIP/FIPS  codes in **Everest** with the data  provided by the United States Postal Service (USPS).  The data provided by USPS  is also known as **City State Product**.


Everest Software supplies you with the City State Product as part of  your license. You can download updated zip code tables from the **Downloads** section of the [Everest  Software Support website](http://support.everestsoftwareinc.com).


{:.note}
Zip code updates include city names, 5-digit  zip codes, and FIPS codes. **Everest**  does not currently support Zip+4 postal codes.


**Periodic Zip/FIPS Code Imports**


Periodically, the USPS releases new zip codes in a file. This file must  be imported using the **Zip/FIPS Code Import**  utility. You can download updated zip code tables from the **Downloads**  section of the [Everest  Software Support website](http://support.everestsoftwareinc.com). The **Zip/FIPS 
 Codes Import** utility updates only the zip code table with new zip  codes and relevant FIPS codes.


{:.note}
After importing zip codes, if there are new FIPS added to the database,  you have to manually go through the log file and modify jurisdiction details  and customer/vendor address details as required. You can view the log  file - **ZipCodeImport.txt** from  the following default path C:\Program Files\Icode\Everest\Client,  unless you changed the path while installing **Everest**.


![]({{site.utl_baseurl}}/img/lens.gif) [The  Jurisdiction Profile]({{site.sc_chm}}/options/sales-tax/tax-jurisdictions/set-up-jurisdictions/jurisdiction_profile.html)


{:.steps}
To import zip codes into Everest, do the  following:

- From the main  menu, select **Utility** > **Import** > **Zipcode****Import**. You will see the [**Zip/FIPS 
 Codes Import**]({{site.utl_baseurl}}/db-utils/zip-codes-import/zip_fips_codes_import_dialog_box.html) dialog box.
- Select the  import file in the **City State****file** field.
- Click **Import** to start the import process.
- When the import  process is complete, you will receive the message "Import Completed Successfully".  Click **OK**.
- Click **View Log** to view details of the imported  zip/FIPS codes.
- Click **Close** to exit the **Zip/FIPS 
 Codes Import** utility.



{:.see_also}
See also
: [Zip  Codes]({{site.sc_chm}}/options/international-set-up/zip-codes/zip_codes.html)
