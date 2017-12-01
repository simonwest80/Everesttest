---
title: Data Warehouse Overview
---

# Data Warehouse Overview


The **Everest Business Intelligence Suite**  creates a data warehouse used with **Everest 
 Advanced Edition** 3.0 and later. This data warehouse is currently  comprised of the sales data mart. This is a subject-oriented database  based on sales transactions such as sales invoices and credit memos.


Data is extracted, transformed, and loaded (ETL) into the **Everest 
 Data Warehouse/Sales Data Mart** from the **Everest**  Database on a regular basis. The sales data is then stored in the **Everest Data Warehouse/Sales Data Mart**.   A **Sales Measure** is a numeric amount such  as quantity or actual sales amount. A **Dimension**  is the context for the **Sales Measure**  in the **Everest Data Warehouse/Sales Data 
 Mart**.  It  answers Who, What, When, Where, and Why questions pertaining to the sales  measure.  The  **Grain** is the level of detail that  the sales data mart attempts to describe. For example, the Sales Data  Mart is at the document line item grain.


The **Everest Data Warehouse/Sales Data 
 Mart** shows sales transactions in 19 default dimensions. In order  to do this, sales amounts and quantities are associated with the dimensions  in small sales chunks. These sales chunks contain document line items  for sales and credit documents and relate to a field in a dimension row.  The sales chunks can be sorted and summed per dimension in a variety of  ways.


{:.example}
For the **Customer 
 Dimension**, there may be a row for Customer A. This row contains  information about that customer such as City, State, and Zip.  There  may be other rows for Customers B, C, and D with similar information.  For the **Location Dimension**, there  may be rows for the Texas, California, and New York offices.  There  is also a **Time Dimension** that  could have information for this week and last week.  Information  about the sales chunks can be requested for each of these dimensions.   If you  need to know the total sales in the Texas office from Customer A for last  week, the sales chunks are sorted and summed to give you the necessary  information.


To speed up the access of this information to the users, **Microsoft 
 SQL Server 2000/2005 Analysis Services (A/S)** is used to perform  summations ahead of time. These summations are stored as cubes of information  for quick retrieval. **Everest** ships  with predefined cube structures that contain aggregated summaries for  sales and credit transactions. Because summations are necessary, data  is provided to users in “almost” real time depending upon your **Extract, 
 Transform, and Load (ETL)** refresh strategy.


The first step in deploying the **Everest 
 Advanced Dashboard** to the end users is to create and set up the  database and dashboard.  Next,  you create the web parts and add them to the shared dashboard.  After  that, you give users permissions to use the shared dashboard using **Microsoft Windows&#174; 
 SharePoint&#174; 
 Services (WSS)**.


{:.note}
**Everest**  ties together WSS and A/S into a corporate dashboard.


The basic steps to complete these tasks and get your dashboard up and  running are provided in these help files.


{:.see_also}
See also
: [Additional  Information]({{site.db_baseurl}}/data-warehouse-overview/additional_information_ead.html)
