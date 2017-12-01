---
title: Masking Cost Information in Stock Transfer
---

# Masking Cost Information in Stock Transfer


**Everest** allows you to hide sensitive  cost information during the stock transfers by masking the amount columns  in the **Stock Transfer** browser **** and **Stock Transfer** document.


![example.gif]({{site.wm_baseurl}}/img/example.gif) You may not want to disclose  cost information to certain people who work with your data.


This can be done by setting the preferences in the work station settings  and flow control preferences.


Preference Settings in the Work Station Setting dialog  box


Clear the **Enable Extended Mode** option  (path: **File &gt; Setup &gt; Preferences 
 &gt; Work Station Settings** dialog box > **Company 
 Settings** tab).


Preference Settings in the Other Flow Control dialog  box:


In the **Type of cost to be displayed 
 in Inventory browsers, Stock Transfer and Pricing Analysis** field,  (path: **File &gt; Set up &gt; Preferences 
 &gt; Flow Control &gt; Other Flow Control** dialog box > **Item Cost/Sales Summary** tab) select  **NONE**.


If the above preferences are set, you will see the **Stock 
 Transfer Amount** column in the **Stock 
 Transfer** browser masked with \*\*\*\*. The same masking occurs in the  **Amount** column in the **Grid 
 Information** section and **Total** field in the **Results** section  of the **Stock Transfer** document.


![]({{site.wm_baseurl}}/img/note.gif) You must  have adequate security rights to enable/disable extended mode. Ensure  that security rights are not assigned to users from whom you want to mask  the costs.


{:.see_also}
See also
: [Stock  Transfers Browser]({{site.wm_baseurl}}/inv-adj/stk-trans/create-stock-transfer-document/the_stock_transfers_browser_new.html)
: [Stock  Transfers Profile]({{site.wm_baseurl}}/inv-adj/stk-trans/create-stock-transfer-document/the_stock_transfers_profile.html)
