---
title: Automatic
---

# Automatic


When a sales return document is created, the **Tax 
 Calculation Type** field defaults to **Automatic**.  Taxes are automatically calculated based on the jurisdiction that the  sale belongs to. **Everest** determines  the sales jurisdiction based on the shipping address and the login  jurisdiction.


If the option selected in the **Tax Calculation 
 Type** field was previously set to **Manual**  or **Special tax rule override**,  and you have selected **Automatic**,  the taxes are recalculated.


Taxes are recalculated whenever there is a change in the delivery method  or shipping address.


When a new item is added to the document, the taxes are automatically  calculated based on the jurisdiction of the sales return document.


When you open a saved but unposted sales return document with the Tax  Calculation Type set to Automatic, the system compares the stored tax  code with the current tax settings in the **Jurisdiction**  and **Special Tax Rules** profiles.  If a difference exists for the tax code assigned to that jurisdiction  or for the vendor/item/category based on the special tax rule, you get  a message asking if you would like to update the tax details based on  the current tax settings. Click **Yes**  to update the tax details (and recalculate all affected tax-related fields)  or **No** to retain the original settings.  If you click **Yes** to update the  information you must save the document to retain the new settings.


{:.note}
When you manually change the tax code, the **Tax 
 Calculation Type** field displays the **Manual 
 override** option.


{:.see_also}
See also
: [Tax  Calculation Type]({{site.sp_baseurl}}/misc/tax_calculation_type_pyt_infon_sales_return_docs.html)
