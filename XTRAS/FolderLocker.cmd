cls
@ECHO OFF
title Folder Locker

if EXIST "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" goto UNLOCK
if NOT EXIST Locker goto MDLOCKER

:CONFIRM
    echo Lock the folder? (Y/N)
    set/p "cho=>"
    if %cho%==Y goto LOCK
    if %cho%==y goto LOCK
    if %cho%==n goto END
    if %cho%==N goto END

    echo Invalid choice
    goto CONFIRM

:LOCK
    ren Locker "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    attrib +h +s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    echo Folder locked
    goto End

:UNLOCK
    echo Enter unlocker password: 
    set/p "pass=>"
    if NOT %pass%==CSharp goto FAIL
    attrib -h -s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    ren "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" Locker
    echo Folder unlocked successfully
    cd Locker
    echo You can now close this window
    Brave
    goto End

:FAIL
    echo Invalid password
    goto end

:MDLOCKER
    md   Locker
    echo Locker created successfully
    goto End

:End