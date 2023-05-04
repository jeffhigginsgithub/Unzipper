# Unzipper
A simple tool for unzipping archives.

Some environments don't allow software to be installed if the user doesn't have local administrator permissions, and others won't allow software on a user's system if it's able to create encrypt files. This can cause problems when encrypted archives need to be extracted, as most (all?) free tools that can decrypt archives also have the ability to create encrypted archives.

This is a simple tool that will only unzip - no zipping. It supports regular, password-protected, and filename encrypted .zip, .7z, and .rar files. The interface is straight-forward so that it's simple to use. Additional options are:

* the automatic creation of destination subfolder (with the same name as the archive) or the choice of where to extract the files
* use of a password if required to extract the files
* the option to overwrite existing files or to skip over them instead
* the option to open a new File Explorer window at the unzip location once finished

Cancellation of the extraction process is also supported.
