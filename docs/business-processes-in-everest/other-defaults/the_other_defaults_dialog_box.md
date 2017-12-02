---
title: The Other Defaults Dialog Box
---

# The Other Defaults Dialog Box


**Default Shift Code**
: Specify the default shift code. If you do not specify  a shift code for a user, and create a time log for the user (by using  the **Clock 
 In/Out** dialog box), the shift code in the **Employee Logs** browser defaults to the shift code specified here.


Prompt user when creating a new customer or vendor if  information is duplicated for


**Telephone or fax number**
: Select this check box to be prompted when you enter  a telephone number or fax number that already exists in another customer  or vendor account.


**Account name or first name and last name**
: Select this check box to be prompted when you enter  an account name or first name and last name that already exists in another  customer or vendor account.


**Address**
: Select this check box to be prompted when you enter  an address that already exists in another customer or vendor account.
: ![]({{site.bp_baseurl}}/img/note.gif) You are prompted only if a duplicate  billing address is entered.


**E-mail**
: Select this check box to be prompted when you enter  an e-mail address that already exists in another customer or vendor account.


Global Multimedia Repository


**Global Multimedia Repository**
: You can specify the global directory in which the  multimedia files are located in this field. When you specify the multimedia  repository paths, the local repository specified in the **Workstation 
 Settings** takes precedence over the global one defined in the **Other Default** preferences. Only when  the local repository is not specified, **Everest**  copies the file to the global repository. If the multimedia repository  is specified neither in the **Workstation 
 Settings** nor in the default preferences, **Everest**  informs you that the files will not be copied to the global multimedia  repository. The option **Copy to Multimedia 
 Repository** is disabled in the profiles and the files are accessed  from the path from where they are attached. The file is available only  to the user who saves the file and cannot be viewed by other users.
: ![]({{site.bp_baseurl}}/img/note.gif) • The global repository specified  in the **Other Default** preferences  should be shared with the network with full rights. All users can then  access the file attachments specified in the multimedia browser.
: • If you change the Multimedia Repository path,  all files in the Multimedia Repository can be accessed from the new location  provided that they are manually moved to the new location.


**[]()Freight Padding**
: Freight Padding is an additional charge over the  actual freight expenses. This amount is treated as a profit. Freight padding  is computed only on sales and sales return documents; and is accounted  as normal freight charges.
: This field allows you to specify whether the freight  charges must be padded, and the amount thereof. The options available  in this field are:


| Option | Description |
| None | Freight padding will not be allowed. |
| Percentage | Freight will be padded by the specified percentage when freight is computed.<br/><br/><br/>![]({{site.bp_baseurl}}/img/example.gif) If freight padding is specified as 5 percent and the  freight computed on a sales document is $100, the total amount of freight  displayed on the document will be $105. |
| Amount | Freight will be padded by the specified amount when freight is computed.<br/><br/><br/>![]({{site.bp_baseurl}}/img/example.gif) If freight padding is specified as $2 and the freight  computed on a sales document is $100, the total amount of freight displayed  on the document will be $102. |

: If you select “Amount” or “Percentage”, the **Freight Padding Applied** check box on  sales and sales return document profiles is automatically selected.
: The amount of freight padding is displayed in the  **Padding** field of the [**Everest Freight Estimator** dialog box]({{site.sp_chm}}/sales-docs/docs-profile/options/utility/freight-est/everest-freight-estimator/the_everest_freight_estimator_dialog_box.html).
: ![]({{site.bp_baseurl}}/img/note.gif)  The  **Rate Shop** browser accessed by  clicking the **Rate Shop** button  displays the **Padding Amount** specified  in the default preferences. If a **Padding 
 Amount** is specified in the [**Carrier** profile]({{site.sc_chm}}/misc/delivery_method_profile_rate_tab.html), it takes precedence  over that specified in the default preferences.


**Freight Padding Amount/Freight Padding Percent**
: Enter the freight padding percentage or amount.  This field is dependent on the option you select in the **Freight****Padding** field.


| **Option Selected** | **Description** |
| None | This field is disabled. |
| Percentage | The field name changes to **Freight****Padding Percent**. |
| Amount | The field name changes to **Freight****Padding Amount**. |

: ![]({{site.bp_baseurl}}/img/note.gif)  You  can also enter a negative amount/percentage. However, the net freight  amount after applying the padding cannot be less than zero (i.e. freight  cannot be negative).


**Define % change permitted to line item amounts  on saved purchase receipts/invoices**


This section allows you to specify the percentage increase or decrease  that you would like to permit for the editable fields in a purchase receipt  or invoice. Adequate security rights are required to modify a purchase  receipt or invoice beyond the specified limits.


**% Change allowed for increases**
: Specify a value permissible for an increase in the  amount of a purchase receipt/invoice. If the percentage **increase 
 on editing a purchase receipt/invoice is expected to exceed the permissible 
 limit, you are not allowed to modify the document. By default, this field 
 will have 0%.**


**% Change allowed for decreases**
: Specify a value permissible for a decrease in the  amount of a purchase receipt/invoice. If the percentage **decrease 
 on editing a purchase receipt/invoice is expected to exceed the permissible 
 limit, you are not allowed to modify the document. By default, this field 
 will have 0%.**


{:.note}
The permissible % change will be calculated  for each line Item individually on the Line Item net amount and not on  the Document Amount.


{:.example}
**Scenario 1**


You create a purchase receipt for an item wherein the item price/unit  is $10 and the add-on cost is $50. The percentage change allowed for increases  is 10%. At a later date, you modify the document to increase the item  price/unit to $20 and reduce the add-on cost to $45.


The percentage change for this modification is calculated as follows:
: Original Purchase  Receipt Line Item Amount - $60 ($10 + $50)
: Modified Purchase  Receipt Line item Amount - $65 ($20 + $45)
: % Change = Variance  in Amount / Original Amount \* 100
: =  5 / 60 \* 100
: =  8.33%


Since 8.33% falls within the permissible percentage of change for increases,  you can modify the purchase receipt.


**Scenario 2**


You create a purchase receipt for an item wherein the item price/unit  is $10 and the add-on cost is $50. The percentage change allowed for decreases  is 30%. At a later date, you modify the document to reduce the item price/unit  to $5 and the add-on cost to $40.


The percentage change for this modification is calculated as follows:
: Original Purchase  Receipt Line Item Amount - $60 ($10 + $50)
: Modified Purchase  Receipt Line item Amount - $45 ($5 + $40)
: % Change = Variance  in Amount / Original Amount \* 100
: =  15 / 60 \* 100
: =  25%


Since 25% falls within the permissible percentage of change for decreases,  you can modify the purchase receipt.


**Default FOB Type in Purchase Documents**
: Select the FOB (Free on Board) Type for all new  purchase documents. The FOB Type identifies both the physical location  where the title of the items passes to the buyers and the party responsible  for payment of freight.

- **FOB 
 Origin** - Indicates that the buyer assumes title to the goods the  moment the carrier signs the bill of lading. The buyer is responsible  for paying shipment charges incurred.
- **FOB 
 Destination** - Indicates that the seller retains title to the goods  until the goods are delivered to the buyer. The seller is responsible  for payment of freight charges incurred until the goods reach the destination.



{:.see_also}
See also
: [Other Defaults]({{site.bp_baseurl}}/other-defaults/other_defaults_dialog_box.html)
