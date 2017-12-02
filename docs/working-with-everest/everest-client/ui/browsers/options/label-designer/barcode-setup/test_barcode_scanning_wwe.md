---
title: Test Barcode Scanning
---

# Test Barcode Scanning


Now that you have configured your barcodes in **Everest**  and printed them, you should test the barcode scanning. The best place  to test the barcodes is in the **Commit 
 Inventory** screen, but you can also scan the barcodes to add line  items in POS and sales orders. Scanning the barcode in the Items browser  will yield inconsistent results as it was not designed for this purpose.


{:.steps}
To test your barcodes using the Commit Inventory  screen, do the following:

- Open a new sales  order.
- Manually add the  selected line items used to create the labels to the sales order.
- Select **Options**  > **Commit Inventory** or press  the **Ctrl+`** keys to access the  **Commit** **Inventory**  screen.



![]({{site.wwe_baseurl}}/img/commit_inventory_screen_wwe.gif)


**Figure: Commit Inventory Screen**

- Scan the barcodes  and see if they are correctly committed on the sales order.  If  the scan is successful, the **Committed**  column will be incremented by a quantity of 1 and you will NOT see a red  error message.



![]({{site.wwe_baseurl}}/img/successful_scan_wwe.gif)


**Figure: Successful Scan Shows Committed Item**

- If there is a problem  scanning the barcode label, you will receive an error message. Check your  configurations and test again until your tests are successful.\



![]({{site.wwe_baseurl}}/img/unsuccessful_scan_wwe.gif)


**Figure: Incorrect Scan Message**


{:.note}
When you scan a barcode label to Word, Excel,  and Notepad, it should EXACTLY match the value in **Everest**.  Your barcode scanner is really just a fast keyboard; to Everest what you  scan looks just like what you type. The barcode is just a special font  that only the scanner can read.


{:.see_also}
See also
: [Set  Barcode Preferences (Optional)]({{site.wwe_baseurl}}/everest-client/ui/browsers/options/label-designer/barcode-setup/set_barcode_preferences_optional_wwe.html)
