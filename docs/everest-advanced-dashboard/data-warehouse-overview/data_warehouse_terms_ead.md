---
title: Data Warehouse Terms
---

# Data Warehouse Terms


**Context**
: The **Context**  answers Who, What, When, Where, Why, and How.


**Cubes**
: **Cubes** are  the pre-aggregated summations of data from the data mart.


**Data Warehouse/Sales Data Mart**
: The **Data Warehouse/Sales 
 Data Mart** is the relational database that stores the transformed  sales data in a “star” schema.


**Dimension**
: A **Dimension**  puts the sales measures in context.


**ETL – Extract, Transform, and Load**
: **ETL** is the  process of pulling the data from the **Everest**  database into the data warehouse, analyzing it, and formatting it in the  data mart structure. The data from the data mart is used for display on  the dashboard web site.  The  ETL is run from a minimum of once per day.


**Grain**
: The **Grain**  is the level that the sales data mart attempts to describe. For example,  the sales data mart is at the document line item grain.


**OLAP**
: **Online Analytical 
 Processing** (OLAP) is the system architecture for Business Intelligence  technologies.


**Microsoft Office Web Components (OWC)**
: **OWC** provides  an OLAP client. Users with a valid license for Microsoft Office will be  able to use the OWC client from the dashboard web part title bar.  Users  without a valid license for Microsoft Office can install a free OWC OLAP  component from the Microsoft web site that has similar but limited functionality.


**Microsoft SQL Server 2000/2005 Analysis Services  (A/S)**
: **Microsoft SQL Server 
 2000/2005 Analysis Services (A/S)** performs calculations on the  data in the data warehouse ahead of time and stores the information in  a “cube”. This allows the information to be quickly reported to the end  user. The user does not have to wait for the calculations to be completed.


**Sales Measure (Fact)**
: A **Sales Measure**  or **Fact** is a numeric amount such  as quantity, retail prices, and actual sales amount.


**Web Parts**
: **Web Parts**  provide a graphical display of information from the cubes on the web site.


{:.see_also}
See also
: [Data Warehouse  Overview]({{site.db_baseurl}}/data-warehouse-overview/data_warehouse_overview_ead.html)
