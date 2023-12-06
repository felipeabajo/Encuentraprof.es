1. Remove request/approval functionality from Branch9 (https://github.com/felipeabajo/ClasesdeskatecomBlazorServer). Comment every reference to Approved/Unapproved Firstname/Lastname. Revert changes in ApplicationUser. Comment every reference to Requests. Bind SfText to user."Properties". Remove variables for properties.
2. Check publicProfile availability on filling the last missing required field (it should become available) without having to refresh the page. Add logic that sets publicProfile to false if any of the requirements is not met. How to do it? I could do it directly on AreRequiredFieldsRequestFilled, in case false,  user.PublicProfile = false. UpdateContext(user).
3. Clean-up in PersonalInformation: remove commented code, remove username,remove functionality other than updating user for lastname, remove call this.OnAfterRenderAsync(true) for firstname and lastname, remove teacherNeverPublicAlert.Refresh(); in every reference except PublicProfileValueChangeHandler. Change alignment of formfields.
4. Clean-up comments. Catch up implementation in Image.
5. Remove UploadStart Event for Setting userId (done with BeforeUpload).
6. Clean-up IsUserImagePathURLNull in ImagePersonalController. Comment references to requests in PersonalInformation.
7. Change name of changeInRequiredFields and areRequiredFieldsFilled for variable and methods.
8. Restore IsUserImagePathURLNull method in ImagePersonalController (since in reality it's used).
9. Info icon por price per hour.
10. Check behaviour when a user removes information from Personal Information. There're probably better UX than this, but for now, it's allowed to remove it, making sure that if the fields are empty, behaviouris as null. Check no longer happening: problem with firstname Field on Edge only, that when focus out (spotted when focused via mouse), it appears a strange shadow. I think it has to do with the box with the suggestions.
11. Change place of info-icon for image (now it's hidden and only displayed if user edits). Included as plain text in Dialog template and icon without hover functionality.
