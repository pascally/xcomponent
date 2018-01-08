﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;

namespace XComponent.SwaggerPetstore.Common
{
    public interface IInternalAPI
    {
		void Init(Context context, string privateTopic = null);

		void AddPet(Context context, string privateTopic = null);

		void CreateAddPetHttpRequest(Context context, string privateTopic = null);

		void UpdatePet(Context context, string privateTopic = null);

		void CreateUpdatePetHttpRequest(Context context, string privateTopic = null);

		void FindPetsByStatus(Context context, string privateTopic = null);

		void CreateFindPetsByStatusHttpRequest(Context context, string privateTopic = null);

		void FindPetsByTags(Context context, string privateTopic = null);

		void CreateFindPetsByTagsHttpRequest(Context context, string privateTopic = null);

		void GetPetById(Context context, string privateTopic = null);

		void CreateGetPetByIdHttpRequest(Context context, string privateTopic = null);

		void UpdatePetWithForm(Context context, string privateTopic = null);

		void CreateUpdatePetWithFormHttpRequest(Context context, string privateTopic = null);

		void DeletePet(Context context, string privateTopic = null);

		void CreateDeletePetHttpRequest(Context context, string privateTopic = null);

		void UploadFile(Context context, string privateTopic = null);

		void CreateUploadFileHttpRequest(Context context, string privateTopic = null);

		void GetInventory(Context context, string privateTopic = null);

		void CreateGetInventoryHttpRequest(Context context, string privateTopic = null);

		void PlaceOrder(Context context, string privateTopic = null);

		void CreatePlaceOrderHttpRequest(Context context, string privateTopic = null);

		void GetOrderById(Context context, string privateTopic = null);

		void CreateGetOrderByIdHttpRequest(Context context, string privateTopic = null);

		void DeleteOrder(Context context, string privateTopic = null);

		void CreateDeleteOrderHttpRequest(Context context, string privateTopic = null);

		void CreateUser(Context context, string privateTopic = null);

		void CreateCreateUserHttpRequest(Context context, string privateTopic = null);

		void CreateUsersWithArrayInput(Context context, string privateTopic = null);

		void CreateCreateUsersWithArrayInputHttpRequest(Context context, string privateTopic = null);

		void CreateUsersWithListInput(Context context, string privateTopic = null);

		void CreateCreateUsersWithListInputHttpRequest(Context context, string privateTopic = null);

		void LoginUser(Context context, string privateTopic = null);

		void CreateLoginUserHttpRequest(Context context, string privateTopic = null);

		void LogoutUser(Context context, string privateTopic = null);

		void CreateLogoutUserHttpRequest(Context context, string privateTopic = null);

		void GetUserByName(Context context, string privateTopic = null);

		void CreateGetUserByNameHttpRequest(Context context, string privateTopic = null);

		void UpdateUser(Context context, string privateTopic = null);

		void CreateUpdateUserHttpRequest(Context context, string privateTopic = null);

		void DeleteUser(Context context, string privateTopic = null);

		void CreateDeleteUserHttpRequest(Context context, string privateTopic = null);

		void SendRequest_AddPetOperation(Context context, string privateTopic = null);

		void SendRequest_UpdatePetOperation(Context context, string privateTopic = null);

		void SendRequest_FindPetsByStatusOperation(Context context, string privateTopic = null);

		void SendRequest_FindPetsByTagsOperation(Context context, string privateTopic = null);

		void SendRequest_GetPetByIdOperation(Context context, string privateTopic = null);

		void SendRequest_UpdatePetWithFormOperation(Context context, string privateTopic = null);

		void SendRequest_DeletePetOperation(Context context, string privateTopic = null);

		void SendRequest_UploadFileOperation(Context context, string privateTopic = null);

		void SendRequest_GetInventoryOperation(Context context, string privateTopic = null);

		void SendRequest_PlaceOrderOperation(Context context, string privateTopic = null);

		void SendRequest_GetOrderByIdOperation(Context context, string privateTopic = null);

		void SendRequest_DeleteOrderOperation(Context context, string privateTopic = null);

		void SendRequest_CreateUserOperation(Context context, string privateTopic = null);

		void SendRequest_CreateUsersWithArrayInputOperation(Context context, string privateTopic = null);

		void SendRequest_CreateUsersWithListInputOperation(Context context, string privateTopic = null);

		void SendRequest_LoginUserOperation(Context context, string privateTopic = null);

		void SendRequest_LogoutUserOperation(Context context, string privateTopic = null);

		void SendRequest_GetUserByNameOperation(Context context, string privateTopic = null);

		void SendRequest_UpdateUserOperation(Context context, string privateTopic = null);

		void SendRequest_DeleteUserOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_AddPetOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_UpdatePetOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_FindPetsByStatusOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_FindPetsByTagsOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_GetPetByIdOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_UpdatePetWithFormOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_DeletePetOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_UploadFileOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_GetInventoryOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_PlaceOrderOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_GetOrderByIdOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_DeleteOrderOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_CreateUserOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_CreateUsersWithArrayInputOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_CreateUsersWithListInputOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_LoginUserOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_LogoutUserOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_GetUserByNameOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_UpdateUserOperation(Context context, string privateTopic = null);

		void ReceiveSuccess_DeleteUserOperation(Context context, string privateTopic = null);

		void ReceiveError_AddPetOperation(Context context, string privateTopic = null);

		void ReceiveError_UpdatePetOperation(Context context, string privateTopic = null);

		void ReceiveError_FindPetsByStatusOperation(Context context, string privateTopic = null);

		void ReceiveError_FindPetsByTagsOperation(Context context, string privateTopic = null);

		void ReceiveError_GetPetByIdOperation(Context context, string privateTopic = null);

		void ReceiveError_UpdatePetWithFormOperation(Context context, string privateTopic = null);

		void ReceiveError_DeletePetOperation(Context context, string privateTopic = null);

		void ReceiveError_UploadFileOperation(Context context, string privateTopic = null);

		void ReceiveError_GetInventoryOperation(Context context, string privateTopic = null);

		void ReceiveError_PlaceOrderOperation(Context context, string privateTopic = null);

		void ReceiveError_GetOrderByIdOperation(Context context, string privateTopic = null);

		void ReceiveError_DeleteOrderOperation(Context context, string privateTopic = null);

		void ReceiveError_CreateUserOperation(Context context, string privateTopic = null);

		void ReceiveError_CreateUsersWithArrayInputOperation(Context context, string privateTopic = null);

		void ReceiveError_CreateUsersWithListInputOperation(Context context, string privateTopic = null);

		void ReceiveError_LoginUserOperation(Context context, string privateTopic = null);

		void ReceiveError_LogoutUserOperation(Context context, string privateTopic = null);

		void ReceiveError_GetUserByNameOperation(Context context, string privateTopic = null);

		void ReceiveError_UpdateUserOperation(Context context, string privateTopic = null);

		void ReceiveError_DeleteUserOperation(Context context, string privateTopic = null);

		void Init(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void AddPet(Context context, XComponent.SwaggerPetstore.UserObject.AddPet transitionEvent, string privateTopic = null);

		void CreateAddPetHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.AddPetOperation transitionEvent, string privateTopic = null);

		void UpdatePet(Context context, XComponent.SwaggerPetstore.UserObject.UpdatePet transitionEvent, string privateTopic = null);

		void CreateUpdatePetHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.UpdatePetOperation transitionEvent, string privateTopic = null);

		void FindPetsByStatus(Context context, XComponent.SwaggerPetstore.UserObject.FindPetsByStatus transitionEvent, string privateTopic = null);

		void CreateFindPetsByStatusHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.FindPetsByStatusOperation transitionEvent, string privateTopic = null);

		void FindPetsByTags(Context context, XComponent.SwaggerPetstore.UserObject.FindPetsByTags transitionEvent, string privateTopic = null);

		void CreateFindPetsByTagsHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.FindPetsByTagsOperation transitionEvent, string privateTopic = null);

		void GetPetById(Context context, XComponent.SwaggerPetstore.UserObject.GetPetById transitionEvent, string privateTopic = null);

		void CreateGetPetByIdHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.GetPetByIdOperation transitionEvent, string privateTopic = null);

		void UpdatePetWithForm(Context context, XComponent.SwaggerPetstore.UserObject.UpdatePetWithForm transitionEvent, string privateTopic = null);

		void CreateUpdatePetWithFormHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.UpdatePetWithFormOperation transitionEvent, string privateTopic = null);

		void DeletePet(Context context, XComponent.SwaggerPetstore.UserObject.DeletePet transitionEvent, string privateTopic = null);

		void CreateDeletePetHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.DeletePetOperation transitionEvent, string privateTopic = null);

		void UploadFile(Context context, XComponent.SwaggerPetstore.UserObject.UploadFile transitionEvent, string privateTopic = null);

		void CreateUploadFileHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.UploadFileOperation transitionEvent, string privateTopic = null);

		void GetInventory(Context context, XComponent.SwaggerPetstore.UserObject.GetInventory transitionEvent, string privateTopic = null);

		void CreateGetInventoryHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.GetInventoryOperation transitionEvent, string privateTopic = null);

		void PlaceOrder(Context context, XComponent.SwaggerPetstore.UserObject.PlaceOrder transitionEvent, string privateTopic = null);

		void CreatePlaceOrderHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.PlaceOrderOperation transitionEvent, string privateTopic = null);

		void GetOrderById(Context context, XComponent.SwaggerPetstore.UserObject.GetOrderById transitionEvent, string privateTopic = null);

		void CreateGetOrderByIdHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.GetOrderByIdOperation transitionEvent, string privateTopic = null);

		void DeleteOrder(Context context, XComponent.SwaggerPetstore.UserObject.DeleteOrder transitionEvent, string privateTopic = null);

		void CreateDeleteOrderHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.DeleteOrderOperation transitionEvent, string privateTopic = null);

		void CreateUser(Context context, XComponent.SwaggerPetstore.UserObject.CreateUser transitionEvent, string privateTopic = null);

		void CreateCreateUserHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.CreateUserOperation transitionEvent, string privateTopic = null);

		void CreateUsersWithArrayInput(Context context, XComponent.SwaggerPetstore.UserObject.CreateUsersWithArrayInput transitionEvent, string privateTopic = null);

		void CreateCreateUsersWithArrayInputHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.CreateUsersWithArrayInputOperation transitionEvent, string privateTopic = null);

		void CreateUsersWithListInput(Context context, XComponent.SwaggerPetstore.UserObject.CreateUsersWithListInput transitionEvent, string privateTopic = null);

		void CreateCreateUsersWithListInputHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.CreateUsersWithListInputOperation transitionEvent, string privateTopic = null);

		void LoginUser(Context context, XComponent.SwaggerPetstore.UserObject.LoginUser transitionEvent, string privateTopic = null);

		void CreateLoginUserHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.LoginUserOperation transitionEvent, string privateTopic = null);

		void LogoutUser(Context context, XComponent.SwaggerPetstore.UserObject.LogoutUser transitionEvent, string privateTopic = null);

		void CreateLogoutUserHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.LogoutUserOperation transitionEvent, string privateTopic = null);

		void GetUserByName(Context context, XComponent.SwaggerPetstore.UserObject.GetUserByName transitionEvent, string privateTopic = null);

		void CreateGetUserByNameHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.GetUserByNameOperation transitionEvent, string privateTopic = null);

		void UpdateUser(Context context, XComponent.SwaggerPetstore.UserObject.UpdateUser transitionEvent, string privateTopic = null);

		void CreateUpdateUserHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.UpdateUserOperation transitionEvent, string privateTopic = null);

		void DeleteUser(Context context, XComponent.SwaggerPetstore.UserObject.DeleteUser transitionEvent, string privateTopic = null);

		void CreateDeleteUserHttpRequest(Context context, XComponent.SwaggerPetstore.UserObject.DeleteUserOperation transitionEvent, string privateTopic = null);

		void SendRequest_AddPetOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_UpdatePetOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_FindPetsByStatusOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_FindPetsByTagsOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_GetPetByIdOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_UpdatePetWithFormOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_DeletePetOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_UploadFileOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_GetInventoryOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_PlaceOrderOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_GetOrderByIdOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_DeleteOrderOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_CreateUserOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_CreateUsersWithArrayInputOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_CreateUsersWithListInputOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_LoginUserOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_LogoutUserOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_GetUserByNameOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_UpdateUserOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void SendRequest_DeleteUserOperation(Context context, XComponent.Common.Event.DefaultEvent transitionEvent, string privateTopic = null);

		void ReceiveSuccess_AddPetOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_UpdatePetOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_FindPetsByStatusOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_FindPetsByTagsOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_GetPetByIdOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_UpdatePetWithFormOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_DeletePetOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_UploadFileOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_GetInventoryOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_PlaceOrderOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_GetOrderByIdOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_DeleteOrderOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_CreateUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_CreateUsersWithArrayInputOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_CreateUsersWithListInputOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_LoginUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_LogoutUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_GetUserByNameOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_UpdateUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveSuccess_DeleteUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.SuccessResponse transitionEvent, string privateTopic = null);

		void ReceiveError_AddPetOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_UpdatePetOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_FindPetsByStatusOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_FindPetsByTagsOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_GetPetByIdOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_UpdatePetWithFormOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_DeletePetOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_UploadFileOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_GetInventoryOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_PlaceOrderOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_GetOrderByIdOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_DeleteOrderOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_CreateUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_CreateUsersWithArrayInputOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_CreateUsersWithListInputOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_LoginUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_LogoutUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_GetUserByNameOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_UpdateUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void ReceiveError_DeleteUserOperation(Context context, XComponent.SwaggerPetstore.UserObject.ErrorResponse transitionEvent, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.AddPet evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.AddPetOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UpdatePet evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UpdatePetOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.FindPetsByStatus evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.FindPetsByStatusOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.FindPetsByTags evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.FindPetsByTagsOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetPetById evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetPetByIdOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UpdatePetWithForm evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UpdatePetWithFormOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.DeletePet evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.DeletePetOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UploadFile evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UploadFileOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetInventory evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetInventoryOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.PlaceOrder evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.PlaceOrderOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetOrderById evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetOrderByIdOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.DeleteOrder evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.DeleteOrderOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.CreateUser evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.CreateUserOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.CreateUsersWithArrayInput evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.CreateUsersWithArrayInputOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.CreateUsersWithListInput evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.CreateUsersWithListInputOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.LoginUser evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.LoginUserOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.LogoutUser evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.LogoutUserOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetUserByName evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.GetUserByNameOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UpdateUser evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.UpdateUserOperation evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.DeleteUser evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.DeleteUserOperation evt, string privateTopic = null);

		void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.SuccessResponse evt, string privateTopic = null);

		void SendEvent(XComponent.SwaggerPetstore.UserObject.ErrorResponse evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.AddPet evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.AddPetOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UpdatePet evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UpdatePetOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.FindPetsByStatus evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.FindPetsByStatusOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.FindPetsByTags evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.FindPetsByTagsOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetPetById evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetPetByIdOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UpdatePetWithForm evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UpdatePetWithFormOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.DeletePet evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.DeletePetOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UploadFile evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UploadFileOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetInventory evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetInventoryOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.PlaceOrder evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.PlaceOrderOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetOrderById evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetOrderByIdOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.DeleteOrder evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.DeleteOrderOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.CreateUser evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.CreateUserOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.CreateUsersWithArrayInput evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.CreateUsersWithArrayInputOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.CreateUsersWithListInput evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.CreateUsersWithListInputOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.LoginUser evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.LoginUserOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.LogoutUser evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.LogoutUserOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetUserByName evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.GetUserByNameOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UpdateUser evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.UpdateUserOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.DeleteUser evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.DeleteUserOperation evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.SuccessResponse evt, string privateTopic = null);

		void SendEvent(StdEnum stdEnum, XComponent.SwaggerPetstore.UserObject.ErrorResponse evt, string privateTopic = null);

	}
}
