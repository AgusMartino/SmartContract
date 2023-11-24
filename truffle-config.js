const { infuraProjectId, mnemonic, etherscanApiKey } = require('./secrets.json');
const HDWalletProvider = require('@truffle/hdwallet-provider');

module.exports = {
    networks: {
        rinkeby: {
          provider: () => new HDWalletProvider(
            mnemonic, `https://rinkeby.infura.io/v3/${infuraProjectId}`
          ),
          network_id: 4,
          gasPrice: 10e9,
          skipDryRun: true
        },
        ropsten: {
          provider: () => new HDWalletProvider(
            mnemonic, `https://ropsten.infura.io/v3/${infuraProjectId}`
          ),
          network_id: 3,
          gasPrice: 10e9,
          skipDryRun: true
        },
        kovan: {
          provider: () => new HDWalletProvider(
            mnemonic, `https://kovan.infura.io/v3/${infuraProjectId}`
          ),
          network_id: 42,
          gasPrice: 10e9,
          skipDryRun: true
        },
        goerli: {
          provider: () => new HDWalletProvider(
            mnemonic, "https://ethereum-goerli.publicnode.com"
          ),
          network_id: 5,
          gasPrice: 10e9,
          skipDryRun: true
        }
      },
    
      // Set default mocha options here, use special reporters etc.
      mocha: {
        // timeout: 100000
      },
    
      // Configure your compilers
      compilers: {
        solc: {
          version: "0.6.12",    // Fetch exact version from solc-bin (default: truffle's version)
          // docker: true,        // Use "0.5.1" you've installed locally with docker (default: false)
          // settings: {          // See the solidity docs for advice about optimization and evmVersion
          //  optimizer: {
          //    enabled: false,
          //    runs: 200
          //  },
          //  evmVersion: "byzantium"
          // }
        }
      },
      plugins: [
        'truffle-plugin-verify'
      ],
      api_keys: {
        etherscan: etherscanApiKey
      }
    };