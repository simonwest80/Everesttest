---
title: "Example: Create an Interactive Filter with Drill-down Documents and Profiles"
---

# Example: Create an Interactive Filter with Drill-down Documents and  Profiles


The Advanced Query Builder allows you to create powerful  filters that can prompt users for specific parameters when running the  filters. After making parameter selections, they can also drill-down into  selected documents and profiles to view additional information.


Scenario: A company wants to create a filter that will show  all sales orders over a specified dollar amount for a specified payment  term. After selecting the dollar amount and payment term, they would like  to drill-down further into the query results and be able to open the sales  orders and customer profiles in **Everest**.


For advanced users who know SQL, the SQL query used for this  sample filter is:


SELECT


INVOICES.STATUS,


INVOICES.DOC\_NO,


INVOICES.DATE\_FLD,


INVOICES.CUST\_CODE,


INVOICES.DEP,


INVOICES.TERMS,


INVOICES.DOC\_ALIAS


FROM


INVOICES  WITH (NOLOCK)


WHERE


STATUS  = 8 AND


INV\_AMOUNT  > :AMOUNT AND


TERMS  = :TERMS


If you are not familiar with SQL, follow the steps below  to create the query.


{:.steps}
To create a sample interactive query with  drill-down documents and profiles, do the following:

- From the main menu  bar, select **Utility** > **Advanced Query Builder**. You will see  the **Advanced** **Query 
 Builder**.
- Enter "Sales  Documents - Interactive Filter" in the **Filter 
 Name** field, so that you can save your query and use it at a later  time. The filter name must be unique.



![]({{site.utl_baseurl}}/img/interactive_filter_step1_ut.gif)


**Figure: Advanced Query Builder - Enter Query  Name**

- Double-click the  "INVOICES" table from the **Everest 
 Schema Information (Tables)** section on the right. You will see  a red check mark in front of the selected table.



![]({{site.utl_baseurl}}/img/interactive_filter_step2_ut.gif)


**Figure: Advanced Query Builder - Add INVOICES  Table**

- In the INVOICES  table in the **Custom Query Builder**  section, select the following fields to be retrieved:



STATUS


DOC\_NO


DATE\_FLD


CUST\_CODE


DEP


TERMS


DOC\_ALIAS


![]({{site.utl_baseurl}}/img/interactive_filter_step3_ut.gif)


**Figure: Advanced Query Builder - Custom Query  Builder section**

- Next, specify the  conditions for the query in the **Filters**  tab:
- Enter condition  1 (**STATUS = 8**).
- Click the ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif) lookup button and select **Add 
 condition** to add the first condition.
- Click the first blue  line and enter **STATUS**.
- Do not change the  red "=" (equals) sign.
- Click the second  blue line and enter **8**. (7=Sales  Quote, 8=Sales Order, 9=Sales Invoice, 10=Credit Quote, 11=Credit Order,  and 12=Credit Memo) This condition filters for document type. You can  find this information in the Data Dictionary or the Everest Case Tool.  "Status = 8" filters for Sales Orders.
- Enter condition  2 (**INV_AMOUNT &gt; :AMOUNT**).
- Click the ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif) lookup button again and select **Add 
 condition** to add the second condition.
- Click the first blue  line on the second row for the second condition and enter **INV_AMOUNT**.
- Change the red equals  sign to a "**&gt;**" (greater  than) sign.
- Click the second  blue line on the second row for the second condition and enter **:AMOUNT**.  In this case, the colon (**:**) is  used to indicate that this is a parameter that can be selected. The second  condition allows you to select all sales orders greater than a selected  amount.
- Enter condition  3 (**TERMS = :TERM**).
- Click the ![]({{site.utl_baseurl}}/img/aqb_lookup_button_ut.gif) lookup button again and select **Add 
 condition** to add the third condition.
- Click the first blue  line on the third row for the third condition and enter **TERMS**.
- Do not change the  red "**=**" (equals) sign.
- Click the second  blue line on the third row for the third condition and enter **:TERM**.  The colon (**:**) indicates that TERM  is a parameter. The third condition allows you to select all sales orders  that have the selected term.



![]({{site.utl_baseurl}}/img/interactive_filter_step5a.gif)


**Figure: Advanced Query Builder - Conditions Added  to Filters Tab**

- Click the **Browser Settings** tab, and specify **INVOICES.DOC_NO** as the primary key.



![]({{site.utl_baseurl}}/img/interactive_filter_step6_ut.gif)


**Figure: Advanced Query Builder - Browser Settings  Tab**

- Click the **Field Settings** tab.
- For the INVOICES.DOC\_NO  field:
- In the **Searchable**  column, select the checkbox to allow local searching on this column.
- In the **Action**  column, select **Open Documents Profile**.
- In the **Action 
 Parameter 1** field, select **STATUS**.
- In the **Action 
 Parameter 2** field, select **DOC_NO**.



![]({{site.utl_baseurl}}/img/lens.gif)[Advanced  Query Builder Supported Actions]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/advanced_query_builder_supported_actions_ut.html)

- For the INVOICES.CUST\_CODE  field:
- In the **Action**  column, select **Open Customer Profile**.
- In the **Action 
 Parameter 1** field, select **CUST_CODE**.



![]({{site.utl_baseurl}}/img/interactive_filter_step7_ut.gif)


**Figure: Advanced Query Builder - Field Settings  Tab**

- Click the **Parameter Information** tab.
- For the AMOUNT  field:
- In the **Caption**  column, enter "Sales Amount".
- In the **Data 
 Type** field, select **Numeric**.
- In the **Type**  field, select **Static**.
- Leave the **Default 
 Value** field blank. This allows you to select the value when you  are running the filter.


- For the TERMS field:
- In the **Caption**  column, enter "Payment Term".
- In the **Data 
 Type** field, select **String**.
- In the **Type**  field, select **Static**.
- Leave the **Default 
 Value** field blank.



![]({{site.utl_baseurl}}/img/interactive_filter_step8_ut.gif)


**Figure: Advanced Query Builder - Parameter Information  Tab**

- Click ![]({{site.utl_baseurl}}/img/aqb_save_button_ut.gif) **Save** to save the  "Sales Documents - Interactive Filter" filter.
- Click **Find**  to view the filter output in the **Advanced 
 Query** browser. You will be prompted to add parameter values.



![]({{site.utl_baseurl}}/img/interactive_filter_step9_ut.gif)


**Figure: Advanced Query Builder - Interactive  Query Prompt**

- For this example,  enter "**100**" as the Sales  Amount value.
- Enter "**N30**" as the Payment Term value.  All sales orders over $100 with a payment term of N30 will display in  the filter result.
- Click **OK**  to view the filter.
- You can drill-down  further into the query results. Click a sales order number to open the  sales order or click a customer number to open the customer profile.



![]({{site.utl_baseurl}}/img/interactive_filter_step10_ut.gif)


**Figure: Advanced Query Builder Filter Results  showing Sales Order Profile Drill-down**


![]({{site.utl_baseurl}}/img/interactive_filter_step11_ut.gif)


**Figure: Advanced Query Builder Filter Results  showing Customer Profile Drill-down**


![]({{site.utl_baseurl}}/img/lens.gif)[Query  Details Section - Parameter Information Tab]({{site.utl_baseurl}}/misc/query_details_section_parameter_information_tab_ut.html)


{:.see_also}
See also
: [Steps to Create  a Query]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/steps_to_create_a_query.html)
