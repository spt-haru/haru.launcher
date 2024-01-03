# Haru.Launcher

A minimalistic launcher for EFT.

## Usage

```sh
Haru.Launcher.exe
```

## Implementation

Internally it starts EFT with two flags to enable it to connect with the
server and grab the right profile.

**Flag**      | **Description**
------------- | -------------------------------------------
`-token=<x>`  | passes the accountId to the client
`-config=<x>` | passes the server information to the client
