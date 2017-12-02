---
title: Modify the Vendor Part Number and Put Away Bin Fields
---

# Modify the Vendor Part Number and Put Away Bin Fields


**Everest** allows individual matrix  items to retain the **Vendor Part Number**  and **Put Away Bin** field details,  while modifying other details of all the matrix items from the matrix  group profile.


The system does not overwrite the **Vendor 
 Part Number** and **Put Away Bin**  fields assigned to matrix items while modifying the group profile, provided  these fields are left blank in the group profile.


{:.example}
**Everest**  allows you to modify the Fixed price of all the matrix items from $75  to $72 while modifying the group profile, and retain the details of the  matrix items in the Vendor Part Number and Put Away Bin fields. This is  possible if the Vendor Part Number and Put Away Bin fields are left blank  in the group profile.


{:.steps}
To modify the group profile without overwriting  the Vendor Part Number field of the matrix items, do the following:

- From the **Item** profile, enter the details in the  **Vendor Part Number** and **Put 
 Away Bin** fields for each matrix item and save the profile.
- From  the **Item** profile, open the matrix  group and change the Fixed price to $72. Leave the **Vendor 
 Part Number** and **Put Away Bin**  fields blank in the group profile.
- Click  **Save** and apply the change to all  the matrix items in the **Matrix Items**  browser.



The **Fixed** price is  modified for all the matrix items and **Vendor 
 Part Number** and **Put Away Bin**  field details of the matrix items are retained. The system does not overwrite  the **Vendor Part** **Number**  and **Put Away Bin** fields of the  matrix items while modifying and applying the price field for all the  matrix items from the group profile.


{:.note}
It is mandatory that the number of vendors  in the group and item profile is the same. While modifying the group profile,  the system overwrites the number of vendors in the Item profile with the  number of vendors of the group profile.


**Everest** also allows  you to modify the **Vendor Part Number**  field from the group profile for the first vendor, while retaining the  unique part number assigned for the second vendor in the matrix items.  This is possible if the **Vendor Part Number**  field is blank for the second vendor in the group profile.


{:.example}
You have assigned the same Vendor Part Number  for the first vendor for all matrix items. You wish to modify this part  number. While modifying the first vendor's part number, you wish to retain  the second vendor's part number for the matrix items.


{:.steps}
To modify the Vendor Part Number of the first  vendor for all the matrix items and retain the Vendor Part Number of the  second (another) vendor from the group profile, do the following:

- From the **Item** profile, open each matrix item  and assign the group's **Vendor Part Number**  for the first vendor. Add the second vendor and assign the **Vendor 
 Part Number** that is unique to the matrix item.
- From  the **Item** profile, open the group  profile and modify the Part Number of the first vendor. Leave the **Vendor Part Number** field blank for the  second vendor because the second vendor is assigned a unique Part Number  for each matrix item.
- Click  **Save** and apply the changes to  all the matrix items from the **Matrix 
 Items** browser.



Each matrix item reflects the modified **Vendor 
 Part Number** for the first Vendor and retains the unique Part Number  assigned to it for the second vendor.


The **Put Away Bin**  field also exhibits this unique feature. **Everest**  allows you to modify the group profile while retaining the different bins  assigned to individual matrix items.


{:.example}
Some matrix items are assigned the stock bin  StockCA and some are assigned the stock bin CAMAIN. Leave the **Put 
 Away Bin** field blank while modifying the price of all the matrix  items from the group profile. Each matrix item's stock bin field detail  is retained and the price is modified.


{:.see_also}
See also
: [Modify an Item  Matrix]({{site.mi_baseurl}}/creating-matrix-group-and-matrix-items/modifying_item_matrix.html)
