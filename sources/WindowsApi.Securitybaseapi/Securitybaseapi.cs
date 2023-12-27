// WindowsApi
// Copyright (C) 2020-2022 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Runtime.InteropServices;
using DustInTheWind.WindowsApi.Winnt;

namespace DustInTheWind.WindowsApi.Securitybaseapi
{
    public static class Securitybaseapi
    {
        /// <summary>
        /// The AdjustTokenPrivileges function enables or disables privileges in the specified access token.
        /// Enabling or disabling privileges in an access token requires TOKEN_ADJUST_PRIVILEGES access.
        /// </summary>
        /// 
        /// <param name="TokenHandle">
        /// [in]
        /// A handle to the access token that contains the privileges to be modified. The handle must have
        /// TOKEN_ADJUST_PRIVILEGES access to the token. If the PreviousState parameter is not NULL,
        /// the handle must also have TOKEN_QUERY access.
        /// </param>
        /// 
        /// <param name="DisableAllPrivileges">
        /// [in]
        /// Specifies whether the function disables all of the token's privileges. If this value is TRUE,
        /// the function disables all privileges and ignores the NewState parameter. If it is FALSE,
        /// the function modifies privileges based on the information pointed to by the NewState parameter.
        /// </param>
        /// 
        /// <param name="NewState">
        /// [in, optional]
        /// A pointer to a TOKEN_PRIVILEGES structure that specifies an array of privileges and their attributes.
        /// If the DisableAllPrivileges parameter is FALSE, the AdjustTokenPrivileges function enables, disables,
        /// or removes these privileges for the token. The following table describes the action taken by the
        /// AdjustTokenPrivileges function, based on the privilege attribute.
        /// If DisableAllPrivileges is TRUE, the function ignores this parameter.
        /// </param>
        /// 
        /// <param name="BufferLength">
        /// [in]
        /// Specifies the size, in bytes, of the buffer pointed to by the PreviousState parameter. This
        /// parameter can be zero if the PreviousState parameter is NULL.
        /// </param>
        /// 
        /// <param name="PreviousState">
        /// [out, optional]
        /// A pointer to a buffer that the function fills with a TOKEN_PRIVILEGES structure that contains
        /// the previous state of any privileges that the function modifies. That is, if a privilege has
        /// been modified by this function, the privilege and its previous state are contained in the
        /// TOKEN_PRIVILEGES structure referenced by PreviousState. If the PrivilegeCount member of
        /// TOKEN_PRIVILEGES is zero, then no privileges have been changed by this function. This parameter
        /// can be NULL.
        /// 
        /// If you specify a buffer that is too small to receive the complete list of modified privileges,
        /// the function fails and does not adjust any privileges. In this case, the function sets the
        /// variable pointed to by the ReturnLength parameter to the number of bytes required to hold the
        /// complete list of modified privileges.
        /// </param>
        /// 
        /// <param name="ReturnLength">
        /// [out, optional]
        /// A pointer to a variable that receives the required size, in bytes, of the buffer pointed to by
        /// the PreviousState parameter. This parameter can be NULL if PreviousState is NULL.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero. To determine whether the function
        /// adjusted all of the specified privileges, call GetLastError, which returns one of the following
        /// values when the function succeeds:
        /// - ERROR_SUCCESS - The function adjusted all specified privileges.
        /// - ERROR_NOT_ALL_ASSIGNED - The token does not have one or more of the privileges specified in the
        /// NewState parameter. The function may succeed with this error value even if no privileges were
        /// adjusted. The PreviousState parameter indicates the privileges that were adjusted.
        ///
        /// If the function fails, the return value is zero. To get extended error information, call GetLastError.
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client 	Windows XP [desktop apps | UWP apps]
        /// Minimum supported server 	Windows Server 2003 [desktop apps | UWP apps]
        /// Target Platform 	        Windows
        /// Header 	                    securitybaseapi.h (include Windows.h)
        /// Library 	                Advapi32.lib
        /// DLL 	                    Advapi32.dll
        /// </requirements>
        [DllImport("advapi32.dll")]
        public static extern bool AdjustTokenPrivileges(int TokenHandle, bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLength, out TOKEN_PRIVILEGES PreviousState, out int ReturnLength);
    }
}
