# Polygon ENS minting template

![What the template looks like](./public/livesite.png)

## Welcome 👋
Howdy! This template lets you deploy your own ENS minting website on Polygon.

You'll need a buildspace ENS contract deployed, which you can learn about [here](https://buildspace.so/polygon).

## How to get things working
To mint your own ENS style domain name on Polygon, change the following:

- Update Contract Address
- Update Front-End ABI File

**Contract Address**
```
/src/App.js
const CONTRACT_ADDRESS = "";
```
**ABI File**
```
/utils/Domains.json
{
    "_format": "hh-sol-artifact-1",
    "contractName": "",
    "sourceName": "",
    "abi": [],
    "bytecode": "",
    "deployedBytecode": "",
    "linkReferences": {},
    "deployedLinkReferences": {}
}
```

## Questions?
Have some questions make sure you head over to your [buildspace Dashboard](https://buildspace.so/p/build-polygon-ens) and link your Discord account so you can get access to helpful channels and your instructor!