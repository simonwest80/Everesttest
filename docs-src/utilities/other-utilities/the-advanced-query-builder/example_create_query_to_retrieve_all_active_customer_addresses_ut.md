---
title: "Example: Create a Query to retrieve all Active Customer Addresses"
---

# Example: Create a Query to retrieve all Active Customer Addresses


The procedure below walks you through the process of creating  an example query. It shows you how to create a sample query to retrieve  all customer addresses for customers created on or after the year 2007.


![]({{site.utl_baseurl}}/img/lens.gif)[The  Advanced Query Builder Dialog Box]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/the_query_builder_dialog_box.html)


{:.steps}
To create a sample query to retrieve all  active customer addresses, do the following:

- From the main menu  bar, select **Utility** > **Advanced Query Builder**. You will see  the **Advanced Query Builder** dialog  box.
- Enter "Active Customers"  in the **Filter Name** field, so that  you can save your query and use it at a later time. The filter name must  be unique.
- Double-click the  "ADDRESS" and "CUST" table(s) from the **Everest 
 Schema Information** **(Tables)**  section on the right. You will see a red check mark in front of the selected  tables.



![]({{site.utl_baseurl}}/img/aqb_example1_add_cust_table_ut.gif)


**Figure: Advanced Query Builder – Add Tables**

- In the CUST (Customer)  table in the **Custom Query Builder**  section, select the following field to be retrieved:
- CREAT\_DATE
- In the ADDRESS  table in the **Custom Query Builder**  section, select the following fields to be retrieved:


- CUST\_CODE
- NAME
- STREET\_ADDRESS
- CITY
- STATE
- ZIP
- COUNTRY
- TEL1
- EMAIL



![]({{site.utl_baseurl}}/img/aqb_example1_select_fields_ut.gif)


**Reference: Figure: Advanced Query Builder – Custom  Query Builder section.**

- In the **Custom 
 Query Builder** section, create a join between the ACTIVE field in  the ADDRESS table and the ACTIVE field in the CUST table.
- Click the ACTIVE  field in the ADDRESS table and drag it to the ACTIVE field of the CUST  table. The Active field in the CUST table is highlighted in green before  you release your cursor.



![]({{site.utl_baseurl}}/img/aqb_example1_join_step1_ut.gif)


**Figure: Drag and Drop to Create a Join – The  Field to be Joined is Highlighted in Green**

- After you release  your cursor, you will see a join between the fields as indicated in the  following graphic.



![]({{site.utl_baseurl}}/img/aqb_example1_join_step2_ut.gif)


**Figure: Drag and Drop to Create a Join – A Line  Connecting the Fields Indicates the Join**

- Create another  join between the CUST\_CODE in the ADDRESS table and the CUST\_CODE in the  CUST table.



![]({{site.utl_baseurl}}/img/aqb_custom_query_builder_section_ut.gif)


**Figure: Advanced Query Builder – Custom Query  Builder Section with Two Joins**

- Next, specify the  conditions for the query in the **Filters**  tab:
- Click the  ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif)  lookup  button and select **Add condition**  to add the first condition.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition1_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Select Add Condition**

- Click the first blue  line and select **SUB_TYPE** under  Address.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition3b_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Enter First Condition**

- Click the second  blue line and enter **2**. (1=Vendors,  2=Customers) This condition filters for customer addresses.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition4_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Enter Condition for SUB\_TYPE**

- Click the  ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif)  lookup  button again and select **Add condition**  to add the second condition.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition5_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Add Second Condition**

- Click the first blue  line on the second row for the second condition and select **CREAT_DATE**  under CUST.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition6_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Enter Second Condition**

- Click the red equals  sign on the second row for the second condition and select **&gt;=**.  This indicates that the customer creation date is "greater than or equal  to" the date to be selected.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition7_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Enter Operator for Second Condition**

- Click the second  blue line on the second row for the second condition and enter **01/01/2007**.  This condition filters for all customers created on or after 01/01/2007.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition8_ut.gif)


**Figure: Advanced Query Builder – Filters Tab  – Second Condition**

- Click the **Browser Settings** tab, and specify **ADDRESS.CUST_CODE** as the primary key.



![]({{site.utl_baseurl}}/img/aqb_example1_add_condition9_ut.gif)


**Figure: Advanced Query Builder – Browser Settings  Tab showing Primary Key**

- Click **Save**  to save the "Active Customers" filter.
- Click **Find**  to view the filter output in the **Advanced 
 Query** browser.



![]({{site.utl_baseurl}}/img/lens.gif)[Click  this link to add **Searchable Columns**  to the Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_add_searchable_columns_to_the_query_ut.html)


![]({{site.utl_baseurl}}/img/lens.gif)[Click  this link to **Associate Actions**  with the Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/example_associate_actions_with_the_query_ut.html)


{:.see_also}
See also
: [Steps to Create  a Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/steps_to_create_a_query.html)
