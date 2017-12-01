---
title: Third Party Catalog - All Catalogs
---

# Third Party Catalog - All Catalogs


Using the **All Catalogs** (path:  Sales Return Document profile > **Options 
 &gt; Third Party Catalog &gt; All Catalogs**) option, you can verify  if the item that has been returned by a customer belongs to a third party  catalog. Items contained in a third party catalog do not exist in the  **Everest** database.


{:.steps}
To verify if an item that has been returned  by a customer belongs to a third party catalog, do the following:

- From the **Sales Return Document** profile, select  **Options &gt; Third Party Catalog &gt; 
 All Catalogs**. You will see the [**Third Party Catalogs** browser]({{site.sp_baseurl}}/misc/third_party_catalogs_browser_sales.html) displaying  all the third party catalogs that have been created.
- Select **Options &gt; View Items**. You will see  the **Items** browser listing all  the items contained in the third party catalog.
- Select the  item you want to add to the sales document and click **OK**.



{:.note}
To select more than one item, select the **Shift 
 + Down Arrow** keys.

- The selected  item/s are added to the sales return document.



If the model specified for a third party item retrieved on a sales return  document is the same as the model of any item that exists in the database,  **Everest** retrieves the item that  exists in the database.


![]({{site.sp_baseurl}}/img/example.gif) You  retrieve a third party item called **HP 
 Printer** whose model is **HP DeskJet 
 895**. However, an item called **HP 
 DeskJet Printer** exists in your company's database. The item **HP DeskJet 
 Printer's** model is also **HP DeskJet 
 895**. In this situation, **Everest**  retrieves the item **HP DeskJet 
 Printer** into the sales return document.


{:.note}
You can specify the model of an item in the **Model**  field of the **Item** profile (path:  **Inventory &gt; Items &gt; Options &gt; 
 Edit &gt; In New Window &gt; General** tab).


{:.see_also}
See also
: [Third  Party Catalogs]({{site.mi_chm}}/third-party-speciality-catalogs/third_party_speciality_catalogs.html)
