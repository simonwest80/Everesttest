---
title: Filter Records Using the Keyword Search
---

# Filter Records Using the Keyword Search


Filtering is a quick way to find a subset of data in a browser. A filtered  browser displays only those records that contain the value you specified.


{:.note}
When you apply a keyword search to a column, the records that match  the specified keyword, partially or completely, are displayed in the browser.  These records can be further filtered based on any other column header,  or by using the column filters or Filter option.


The keyword search option is enabled only for string (including memo)  columns. It is disabled for numeric and date columns.


{:.steps}
To filter a browser using the keyword search, do the following:

- Right-click  on the required column header. You will see the column header right-click  menu.
- In the **Keyword Search** field, enter the keyword  that you want to filter the browser by, and press the **Enter** key.
- The browser  displays the records that partially or completely match the keyword specified  in the **Keyword Search** field. If  no records are found, the browser remains blank.



{:.note}
When records are filtered using the keyword  search, **Everest** displays the details  of the filter above the browser's status bar.


{:.example}
If the **City** column in the **Vendors** browser is filtered for all  records containing the keyword ‘New’, the browser displays all records  which contain ‘New’ in the vendor’s city name. The records containing  ‘New York’  and ‘Newport’ are displayed, as well as all records containing ‘New’ anywhere  in the city name. The following message is displayed:


![]({{site.wwe_baseurl}}/img/wwe_keyword_search_message.gif)


Click on ![]({{site.wwe_baseurl}}/img/wwe_filters_clear_search_button.gif) to clear the filter that has been applied to  the browser.


{:.example}
If the **Terms** column in the **Customers** browser is filtered for the  payment term COD, the browser displays all records containing the payment  term COD. The following message is displayed:


![]({{site.wwe_baseurl}}/img/wwe_keyword_search_message_1.gif)


Click on ![]({{site.wwe_baseurl}}/img/wwe_filters_clear_search_button.gif) to clear the filter that has been applied to  the browser.


{:.note}
You can filter the displayed records further,  based on any other header column (such as Currency Code or State), or  by using the column filters or Filter option.


{:.see_also}
See also
: [Custom Auto Filter]({{site.wwe_baseurl}}/everest-client/ui/browsers/options/filter/column-filter/custom_auto_filter.html)
: [Remove  Filters from a Browser]({{site.wwe_baseurl}}/misc/remove_filters_from_a_browser.html)
: [Filtering  Records by Using Classic Style and Expert Style Filters]({{site.wwe_baseurl}}/misc/classic_style_and_expert_style_filters_filters_dialog_box.html)
: [Filtering  Records Using the Column Filter]({{site.wwe_baseurl}}/everest-client/ui/browsers/options/filter/column-filter/filtering_records_using_the_column_filter.html)
