---
title: The Retrieve Serial Numbers Dialog Box
---

# The Retrieve Serial Numbers Dialog Box


This dialog box allows you to specify the serial number(s)  of the item to be attached to the document.


Only serial numbers from stock areas that belong to the logged in location  are available for selection, if the **Allow 
 users to access only those stock areas in the logged in location** option  (path: **File** > **Setup**  > **Preferences** > **Flow 
 Control** > **Other Flow Control**  > **General** tab) is selected.  You should have adequate security rights to attach serial numbers from  stock areas belonging to other locations.


Method


This section allows you to specify the method of retrieval of the serial  numbers.


| **Option Name** | **Description** |
| System serial numbers | Select this option to retrieve one item serial number into the document.  The **Serial #** field is displayed  in this section. Specify the required serial number. |
| Range of system serial numbers | Select this option to attach more than one item serial number to the  document. The **Serial # from** and  **Serial # to** fields are enabled.  Specify the range of serial numbers to be attached. |
| Manufacturer's serial number | Select this option to attach the item to the document by specifying  the manufacturer's serial number. The **Manufacturer's <br/> serial #** field is enabled. Specify the required number. |



**History**


Click the ![]({{site.ba_baseurl}}/img/ba_history_button.gif) button, to view details of the serial numbers  attached to or detached from the work order.


The serial number history is available only till you close this profile.  Once you select **Close**, the **Retrieve Serial Numbers** dialog box closes  and you cannot access this information again.


The following details are displayed in the lower half of the **Retrieve 
 Serial Numbers** dialog box:

- Action type


- **Assigned**  - The serial number is assigned to the item in the document.
- **Skipped**  - The serial number cannot be attached to the item as it has already been  assigned in the document.


- The item serial  number that is attached/detached to the document.
- The manufacturer's  serial number if any assigned to the serial number.
- The item code  and description.
- The stock area  from where the item is attached/detached.



{:.see_also}
See also
: [Attach  Serialized Inventory to a Work Order]({{site.ba_baseurl}}/prod-asm/att-cmt-items-to-wo/ser-items/serialized-inventory.html)
