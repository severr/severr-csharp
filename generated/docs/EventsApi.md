# IO.Severr.Api.EventsApi

All URIs are relative to *https://www.severr.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsPost**](EventsApi.md#eventspost) | **POST** /events | Submit an application event or error to Severr


<a name="eventspost"></a>
# **EventsPost**
> void EventsPost (AppEvent data)

Submit an application event or error to Severr

 The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Severr.  ##### Sample POST request body: ``` {  \"apiKey\": \"a9a2807a2e8fd4602adae9e8f819790a267213234083\",  \"classification\": \"Error\",  \"eventType\": \"System.Exception\",  \"eventMessage\": \"This is a test exception.\",  \"eventTime\": 1479477482291,  \"eventStacktrace\": [    {      \"type\": \"System.Exception\",      \"message\": \"This is a test exception.\",      \"traceLines\": [        {          \"function\": \"Main\",          \"line\": 19,          \"file\": \"SeverrSampleApp\\\\Program.cs\"        }      ]    }  ],  \"contextAppVersion\": \"1.0\",  \"contextEnvName\": \"development\",  \"contextEnvHostname\": \"severr.io\",  \"contextAppOS\": \"Win32NT Service Pack 1\",  \"contextAppOSVersion\": \"6.1.7601.65536\" } ``` ##### Sample POST response body (200 OK): ``` { } ``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Severr.Api;
using IO.Severr.Client;
using IO.Severr.Model;

namespace Example
{
    public class EventsPostExample
    {
        public void main()
        {
            
            var apiInstance = new EventsApi();
            var data = new AppEvent(); // AppEvent | Event to submit

            try
            {
                // Submit an application event or error to Severr
                apiInstance.EventsPost(data);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.EventsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**AppEvent**](AppEvent.md)| Event to submit | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

