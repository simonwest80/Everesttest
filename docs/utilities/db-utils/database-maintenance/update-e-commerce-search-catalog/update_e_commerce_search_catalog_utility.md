---
title: Update E-Commerce Search Catalog
---

# Update E-Commerce Search Catalog


**Everest eStorefront** uses the  Full Text Search Catalog in both simple and advanced searches on the online  store. Full Text Search (FTS) is a new component of Microsoft SQL Server  2000 that allows for faster and more flexible search of character based  columns in Microsoft SQL server tables. You can use the Full Text Search  functionality in **Everest eStorefront**  to speed up your search for words in close proximity.


{:.note}
FTS is not set up by default in the standard  installation of Microsoft SQL Server. You need to select **Custom 
 Install** option during setup, and select **Full-Text 
 Search** under **Server Components**.  The Full-Text indices created are not stored within Microsoft SQL Server  but stored externally.


When you install **Everest**, an  FTS Catalog is automatically created. The FTS catalog must be periodically  updated to reflect the changes in the **Everest**  database and Full-Text indexing, or populating the Full Text Catalogs  should be done during periods of low database activity. You can opt for  a full or incremental population of the search catalog, depending upon  your business activity.


{:.steps}
To view the E-Commerce Search Catalog Update  Schedule dialog box, do the following:

- From the main  menu bar, select **Utility** >  **Database Maintenance** > **Update E-Commerce Search Catalog**. You  will see the [**E-Commerce Search Catalog Update Schedule dialog 
 box**]({{site.utl_baseurl}}/misc/e_commerce_search_catalog_update_schedule_dialog_box.html).



{:.note}
The **Update 
 E-Commerce Search Catalog** option is disabled if the **E-Commerce**  option is not activated for the logged in company by providing valid registration  and activation keys.


![]({{site.utl_baseurl}}/img/refer.gif) **Everest eStorefront** Advanced Edition  User Guide
