---
title: Expression Expert - Right (Edit) Panel
---

# Expression Expert - Right (Edit) Panel


This panel displays the queries that you build, by using parameters  from the left panel.


{:.example}
To filter the **Customers** browser  for customers whose first name is Brad, you must define the following  query, by selecting the required parameters from the left panel of the  **Expression Expert** dialog box:


brwcol.first\_name  like '%Brad%'


The query is displayed in the **Edit 
 Panel**. Click **OK** to save  the query. The **Filter Name** dialog  box is displayed. Specify a name for the newly created **Expert 
 Style** filter, and click **OK**.  You will see the **Filters** dialog  box. Click **Apply** to run the filter.


The Customers browser displays only those customers whose first name  is Brad.


![]({{site.wwe_baseurl}}/img/note.gif)Only the records displayed in the browser are filtered.  To filter all the records using the specified criteria, you must first  display all the records in the browser, by using the **Get 
 All** option.


The following message is displayed above the browser’s status bar:


![]({{site.wwe_baseurl}}/img/expert style filter first name brad.bmp)


To further filter the records in the browser, or modify the filter,  double-click the filter details and define additional conditions in the  **Edit Panel**. Click![]({{site.wwe_baseurl}}/img/x.bmp) to clear the filter that has been applied to the browser.


{:.steps}
To define the above mentioned condition,  do the following:

- From the main  menu, select **Invoicing &gt; Customers**.  You will see the **Customers** browser.
- Click the **Expert Style Filter** ![]({{site.wwe_baseurl}}/img/wwe_standard_browser_options_expert_style_filter.gif) icon.  You will see the **Filters** dialog  box.
- Click the drop-down  arrow beside the **Add** button. Select  **Expert Style** from the drop-down  list.
- You will see  the **Expression Expert** dialog box.
- From the **Left** Panel, select BrwCol.FIRST\_NAME,  by clicking the  icon  beside it. The parameter is added to the **Right 
 (Edit) Panel**.
- Double-click **Common 
 SQL Syntaxes 
 &gt; Reserved Words**. You will see the reserved words that can be  used.
- Click LIKE. The word is added to the **Right 
 (Edit) Panel**. You can also enter the word.
- Double-click **Common 
 SQL Syntaxes 
 &gt; Operators &gt; Strings**. You will see the strings that can  be used.
- Click ‘(Single Quote). The string is added to  the **Right (Edit) Panel**. You can  also enter the single quote.
- Double-click **Common 
 SQL Syntaxes 
 &gt; Operators &gt; Arithmetic**. You will see the arithmetic operators  that can be used.
- Click %(Modulo).  The operator is added to the **Right (Edit) 
 Panel**. You can also enter the operator.
- Enter Brad in the **Right 
 (Edit) Panel**.
- Add %(Modulo)  and ‘(Single Quote) to complete the query, using the same procedure.
- Click **OK**. You will see the **Filter 
 Name** dialog box.
- Specify a name  for the newly created **Expert Style**  filter, and click **OK**.
- You will see  the **Filters** dialog box. Click  **Apply** to run the filter.
- The browser  lists records that meet the selection criteria specified.



Similarly, you can add more parameters to the **Expert 
 Style** query, to narrow your search.


{:.see_also}
See also
: [The  Expression Expert Dialog Box]({{site.wwe_baseurl}}/misc/the_expression_expert_dialog_box.html)
: [The Filters  Dialog Box]({{site.wwe_baseurl}}/misc/the_filters_dialog_box.html)
