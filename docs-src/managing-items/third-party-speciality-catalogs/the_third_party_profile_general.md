---
title: The Third Party Profile - General
---

# The Third Party Profile - General


Use the **General** tab of the **Third Party** profile to specify details  such as the code and it's description etc.


**Catalog code**
: Enter the unique code to identify the third party  catalog being defined, using 1 to 15 characters of the supported type  to define the code. The code you enter here will be used to create a subdirectory  within the company folder. When you import the third party data, the data  is copied to this subdirectory.


**Default**
: Select this check box if the third party catalog  is the default catalog. When you save this **Third 
 Party Catalog** profile, no other catalog will have the **Default** field checked.


**Catalog description**
: Enter a suitable description for the third party  catalog, using 1 to 40 characters of any type to define the description.


**Special order item code to be used**
: Specify a suitable non-inventoried item for the  third party.
: When you select an item from a third party catalog  in a sales order, **Everest** uses  the item code mentioned here in the order since the item does not exist  in your database and is available only in the third party catalog. The  item code pertaining to the third party catalog is displayed in the **Third Party Code** column of the Item  Details Grid in the **Sales Order**  profile.
: When a Third Party Item is added to a sales document,  the Model of the Third Party Item is compared to the Model of all the  items in the company’s ITEMS table. If an item is found in the company’s  ITEMS table with a matching Model that item is added to the document as  a company item. If no item with a matching Model is found the Third Party  Item is added to the sales document.


**Default Category**
: Specify the default category for the third party  items to be imported. The **Category**  field defined in the **Item** profile  (Third Party) defaults to the category defined here.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Items  View]({{site.mi_baseurl}}/third-party-speciality-catalogs/third_parties_browser.html)


**Default vendor code**
: Specify the default vendor for the third party.


{:.see_also}
See also
: [Special  Pricing for Third-party Catalog Items]({{site.mi_baseurl}}/misc/special_pricing_for_third-party_catalog_items.html)
