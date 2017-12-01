---
title: The Item Alias Profile - General
---

# The Item Alias Profile - General


Use the **General** tab of the **Item Alias** profile to specify details  such as the code and it's description


General


**Code**
: Enter a unique alphanumeric code for the item alias  using 1 to 25 characters of the supported type. This is a mandatory field.


**Narration**
: Enter a description or other comments concerning  the alias. This narration is for internal use only and is not printed  on any sales or purchase documents.


Alias to


**Item**
: Specify the item code for which the alias is being  defined (i.e. the existing item code). This is a mandatory field.


**Sales Measure**
: Specify the sales measure of the item alias in this  field. This sales measure is used when adding an item alias to a document.  If you do not specify a sales measure in this field, the item will be  added with the default sales measure. Allowed sales measures are available  in the drop-down list.


Overrides


**Description**
: Enter the description to be used, when the item  is retrieved into a document using this alias.


{:.note}
If you leave this field blank, the description of the actual item, for  which the alias is defined, is displayed on the documents or web pages.


**Force Price**
: Select this option to retrieve the price specified  in the **Price** field of the **Item Alias** profile into the sales document  when the item alias is used. You must also select a **Sales 
 Measure** from the drop-down list in the **Alias 
 to** section. If this option is checked, only alias items with the  same measure as the item to which it is defined as an alias can be selected  in purchase and sales documents.
: The **Force Price**  check box is disabled when you define an alias for a kit or a matrix group.


{:.note}
Force price overrides special pricing and quantity pricing for alias  items when this option is checked and the item is retrieved into a sales  document. When this option is unchecked and the item is retrieved into  a sales document, the special pricing and quantity pricing options are  considered.  Alias  items will carry the price on the sales order to the sales invoice. If  this option is checked when the item is retrieved into the sales order  but unchecked when the sales order is converted into sales invoice, the  force price on the sales order will be carried to the sales invoice. If  unchecked when the item is retrieved into the sales order but checked  when the sales order is converted into sales invoice, the force price  will not be relevant and the price on the sales order will be carried  to the sales invoice.


**Price**
: Enter the selling price to be retrieved into a sales  document using the item alias defined in this profile. This field is enabled  only when the **Force Price** check  box is selected.


{:.see_also}
See also
: [The Item Alias  Profile]({{site.mi_baseurl}}/item-alias/item_alias_profile.html)
