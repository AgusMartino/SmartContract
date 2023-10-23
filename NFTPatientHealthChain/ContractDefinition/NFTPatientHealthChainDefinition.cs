using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace SmartContract.Contracts.NFTPatientHealthChain.ContractDefinition
{


    public partial class NFTPatientHealthChainDeployment : NFTPatientHealthChainDeploymentBase
    {
        public NFTPatientHealthChainDeployment() : base(BYTECODE) { }
        public NFTPatientHealthChainDeployment(string byteCode) : base(byteCode) { }
    }

    public class NFTPatientHealthChainDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801562000010575f80fd5b506040516200196938038062001969833981016040819052620000339162000171565b816040518060400160405280600a81526020016913919514185d1a595b9d60b21b815250604051806040016040528060048152602001631394139560e21b815250815f908162000084919062000258565b50600162000093828262000258565b5050506001600160a01b038116620000c457604051631e4fbdf760e01b81525f600482015260240160405180910390fd5b620000cf8162000104565b50600780546001600160a01b039485166001600160a01b03199182161790915560088054929094169116179091555062000320565b600680546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0905f90a35050565b80516001600160a01b03811681146200016c575f80fd5b919050565b5f805f6060848603121562000184575f80fd5b6200018f8462000155565b92506200019f6020850162000155565b9150620001af6040850162000155565b90509250925092565b634e487b7160e01b5f52604160045260245ffd5b600181811c90821680620001e157607f821691505b6020821081036200020057634e487b7160e01b5f52602260045260245ffd5b50919050565b601f82111562000253575f81815260208120601f850160051c810160208610156200022e5750805b601f850160051c820191505b818110156200024f578281556001016200023a565b5050505b505050565b81516001600160401b03811115620002745762000274620001b8565b6200028c81620002858454620001cc565b8462000206565b602080601f831160018114620002c2575f8415620002aa5750858301515b5f19600386901b1c1916600185901b1785556200024f565b5f85815260208120601f198616915b82811015620002f257888601518255948401946001909101908401620002d1565b50858210156200031057878501515f19600388901b60f8161c191681555b5050505050600190811b01905550565b61163b806200032e5f395ff3fe60806040526004361061013c575f3560e01c8063863b3894116100b3578063a22cb4651161006d578063a22cb46514610379578063b88d4fde14610398578063b8fcf937146103b7578063c87b56dd146103d6578063e985e9c5146103f5578063f2fde38b14610414575f80fd5b8063863b3894146102c95780638da5cb5b146102e85780638f3481c014610305578063944074651461031857806394ab67fe1461034657806395d89b4114610365575f80fd5b80633741897211610104578063374189721461020c5780633c168eab1461022b57806342842e0e1461024a5780636352211e1461026957806370a0823114610288578063715018a6146102b5575f80fd5b806301ffc9a71461014057806306fdde0314610174578063081812fc14610195578063095ea7b3146101cc57806323b872dd146101ed575b5f80fd5b34801561014b575f80fd5b5061015f61015a36600461123a565b610433565b60405190151581526020015b60405180910390f35b34801561017f575f80fd5b50610188610484565b60405161016b91906112a2565b3480156101a0575f80fd5b506101b46101af3660046112b4565b610513565b6040516001600160a01b03909116815260200161016b565b3480156101d7575f80fd5b506101eb6101e63660046112e6565b61053a565b005b3480156101f8575f80fd5b506101eb61020736600461130e565b610549565b348015610217575f80fd5b506101eb6102263660046112b4565b6105d7565b348015610236575f80fd5b506101eb6102453660046112e6565b6105f9565b348015610255575f80fd5b506101eb61026436600461130e565b610684565b348015610274575f80fd5b506101b46102833660046112b4565b6106a3565b348015610293575f80fd5b506102a76102a2366004611347565b6106ad565b60405190815260200161016b565b3480156102c0575f80fd5b506101eb6106f2565b3480156102d4575f80fd5b506008546101b4906001600160a01b031681565b3480156102f3575f80fd5b506006546001600160a01b03166101b4565b6102a7610313366004611360565b610705565b348015610323575f80fd5b5061015f6103323660046112b4565b5f908152600a602052604090205460ff1690565b348015610351575f80fd5b506101eb6103603660046112e6565b6108cf565b348015610370575f80fd5b50610188610967565b348015610384575f80fd5b506101eb61039336600461139d565b610976565b3480156103a3575f80fd5b506101eb6103b23660046113e6565b610981565b3480156103c2575f80fd5b506007546101b4906001600160a01b031681565b3480156103e1575f80fd5b506101886103f03660046112b4565b610998565b348015610400575f80fd5b5061015f61040f3660046114bb565b610a09565b34801561041f575f80fd5b506101eb61042e366004611347565b610a36565b5f6001600160e01b031982166380ac58cd60e01b148061046357506001600160e01b03198216635b5e139f60e01b145b8061047e57506301ffc9a760e01b6001600160e01b03198316145b92915050565b60605f8054610492906114ec565b80601f01602080910402602001604051908101604052809291908181526020018280546104be906114ec565b80156105095780601f106104e057610100808354040283529160200191610509565b820191905f5260205f20905b8154815290600101906020018083116104ec57829003601f168201915b5050505050905090565b5f61051d82610a73565b505f828152600460205260409020546001600160a01b031661047e565b610545828233610aab565b5050565b6001600160a01b03821661057757604051633250574960e11b81525f60048201526024015b60405180910390fd5b5f610583838333610ab8565b9050836001600160a01b0316816001600160a01b0316146105d1576040516364283d7b60e01b81526001600160a01b038086166004830152602482018490528216604482015260640161056e565b50505050565b6105df610baa565b5f908152600a60205260409020805460ff19166001179055565b610601610baa565b5f8181526009602052604090205460ff161561065f5760405162461bcd60e51b815260206004820152601f60248201527f4e46542077697468207468697320494420616c72656164792065786973747300604482015260640161056e565b6106698282610bd7565b5f908152600960205260409020805460ff1916600117905550565b61069e83838360405180602001604052805f815250610981565b505050565b5f61047e82610a73565b5f6001600160a01b0382166106d7576040516322718ad960e21b81525f600482015260240161056e565b506001600160a01b03165f9081526003602052604090205490565b6106fa610baa565b6107035f610c38565b565b5f80610710846106a3565b90506001600160a01b038116331461073a5760405162461bcd60e51b815260040161056e90611524565b610745818686610c89565b6007546040516323b872dd60e01b81526001600160a01b038781166004830152838116602483015260448201869052909116906323b872dd906064016020604051808303815f875af115801561079d573d5f803e3d5ffd5b505050506040513d601f19601f820116820180604052508101906107c19190611565565b61080d5760405162461bcd60e51b815260206004820152601c60248201527f546f6b656e20416d6f756e74207472616e73666572206661696c656400000000604482015260640161056e565b6040516bffffffffffffffffffffffff1933606090811b8216602084015287901b16603482015260488101859052606881018490524360888201525f9060a80160408051808303601f1901815282825280516020918201205f818152600a8352839020805460ff1916905588845290830187905290820181905291506001600160a01b0387811691908416907f9f9ac6bca37e427696541548195017f8d7569c1bdff1ba5b97d815bfb9c11f8c9060600160405180910390a395945050505050565b5f6108d9826106a3565b90506001600160a01b03811633146109035760405162461bcd60e51b815260040161056e90611524565b61090e818484610c89565b604080518381525f60208201819052918101919091526001600160a01b0380851691908316907f9f9ac6bca37e427696541548195017f8d7569c1bdff1ba5b97d815bfb9c11f8c906060015b60405180910390a3505050565b606060018054610492906114ec565b610545338383610d36565b61098c848484610549565b6105d184848484610dcc565b60606109a382610a73565b505f6109b960408051602081019091525f815290565b90505f8151116109d75760405180602001604052805f815250610a02565b806109e184610ef2565b6040516020016109f2929190611580565b6040516020818303038152906040525b9392505050565b6001600160a01b039182165f90815260056020908152604080832093909416825291909152205460ff1690565b610a3e610baa565b6001600160a01b038116610a6757604051631e4fbdf760e01b81525f600482015260240161056e565b610a7081610c38565b50565b5f818152600260205260408120546001600160a01b03168061047e57604051637e27328960e01b81526004810184905260240161056e565b61069e8383836001610f82565b5f828152600260205260408120546001600160a01b0390811690831615610ae457610ae4818486611086565b6001600160a01b03811615610b1e57610aff5f855f80610f82565b6001600160a01b0381165f90815260036020526040902080545f190190555b6001600160a01b03851615610b4c576001600160a01b0385165f908152600360205260409020805460010190555b5f8481526002602052604080822080546001600160a01b0319166001600160a01b0389811691821790925591518793918516917fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef91a4949350505050565b6006546001600160a01b031633146107035760405163118cdaa760e01b815233600482015260240161056e565b6001600160a01b038216610c0057604051633250574960e11b81525f600482015260240161056e565b5f610c0c83835f610ab8565b90506001600160a01b0381161561069e576040516339e3563760e11b81525f600482015260240161056e565b600680546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0905f90a35050565b6001600160a01b038216610cb257604051633250574960e11b81525f600482015260240161056e565b5f610cbe83835f610ab8565b90506001600160a01b038116610cea57604051637e27328960e01b81526004810183905260240161056e565b836001600160a01b0316816001600160a01b0316146105d1576040516364283d7b60e01b81526001600160a01b038086166004830152602482018490528216604482015260640161056e565b6001600160a01b038216610d6857604051630b61174360e31b81526001600160a01b038316600482015260240161056e565b6001600160a01b038381165f81815260056020908152604080832094871680845294825291829020805460ff191686151590811790915591519182527f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31910161095a565b6001600160a01b0383163b156105d157604051630a85bd0160e11b81526001600160a01b0384169063150b7a0290610e0e9033908890879087906004016115ae565b6020604051808303815f875af1925050508015610e48575060408051601f3d908101601f19168201909252610e45918101906115ea565b60015b610eaf573d808015610e75576040519150601f19603f3d011682016040523d82523d5f602084013e610e7a565b606091505b5080515f03610ea757604051633250574960e11b81526001600160a01b038516600482015260240161056e565b805181602001fd5b6001600160e01b03198116630a85bd0160e11b14610eeb57604051633250574960e11b81526001600160a01b038516600482015260240161056e565b5050505050565b60605f610efe836110ea565b60010190505f8167ffffffffffffffff811115610f1d57610f1d6113d2565b6040519080825280601f01601f191660200182016040528015610f47576020820181803683370190505b5090508181016020015b5f19016f181899199a1a9b1b9c1cb0b131b232b360811b600a86061a8153600a8504945084610f5157509392505050565b8080610f9657506001600160a01b03821615155b15611057575f610fa584610a73565b90506001600160a01b03831615801590610fd15750826001600160a01b0316816001600160a01b031614155b8015610fe45750610fe28184610a09565b155b1561100d5760405163a9fbf51f60e01b81526001600160a01b038416600482015260240161056e565b81156110555783856001600160a01b0316826001600160a01b03167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b92560405160405180910390a45b505b50505f90815260046020526040902080546001600160a01b0319166001600160a01b0392909216919091179055565b6110918383836111c1565b61069e576001600160a01b0383166110bf57604051637e27328960e01b81526004810182905260240161056e565b60405163177e802f60e01b81526001600160a01b03831660048201526024810182905260440161056e565b5f8072184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b83106111285772184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b830492506040015b6d04ee2d6d415b85acef81000000008310611154576d04ee2d6d415b85acef8100000000830492506020015b662386f26fc10000831061117257662386f26fc10000830492506010015b6305f5e100831061118a576305f5e100830492506008015b612710831061119e57612710830492506004015b606483106111b0576064830492506002015b600a831061047e5760010192915050565b5f6001600160a01b0383161580159061121d5750826001600160a01b0316846001600160a01b031614806111fa57506111fa8484610a09565b8061121d57505f828152600460205260409020546001600160a01b038481169116145b949350505050565b6001600160e01b031981168114610a70575f80fd5b5f6020828403121561124a575f80fd5b8135610a0281611225565b5f5b8381101561126f578181015183820152602001611257565b50505f910152565b5f815180845261128e816020860160208601611255565b601f01601f19169290920160200192915050565b602081525f610a026020830184611277565b5f602082840312156112c4575f80fd5b5035919050565b80356001600160a01b03811681146112e1575f80fd5b919050565b5f80604083850312156112f7575f80fd5b611300836112cb565b946020939093013593505050565b5f805f60608486031215611320575f80fd5b611329846112cb565b9250611337602085016112cb565b9150604084013590509250925092565b5f60208284031215611357575f80fd5b610a02826112cb565b5f805f60608486031215611372575f80fd5b61137b846112cb565b95602085013595506040909401359392505050565b8015158114610a70575f80fd5b5f80604083850312156113ae575f80fd5b6113b7836112cb565b915060208301356113c781611390565b809150509250929050565b634e487b7160e01b5f52604160045260245ffd5b5f805f80608085870312156113f9575f80fd5b611402856112cb565b9350611410602086016112cb565b925060408501359150606085013567ffffffffffffffff80821115611433575f80fd5b818701915087601f830112611446575f80fd5b813581811115611458576114586113d2565b604051601f8201601f19908116603f01168101908382118183101715611480576114806113d2565b816040528281528a6020848701011115611498575f80fd5b826020860160208301375f60208483010152809550505050505092959194509250565b5f80604083850312156114cc575f80fd5b6114d5836112cb565b91506114e3602084016112cb565b90509250929050565b600181811c9082168061150057607f821691505b60208210810361151e57634e487b7160e01b5f52602260045260245ffd5b50919050565b60208082526021908201527f596f7520617265206e6f7420746865206f776e6572206f662074686973204e466040820152601560fa1b606082015260800190565b5f60208284031215611575575f80fd5b8151610a0281611390565b5f8351611591818460208801611255565b8351908301906115a5818360208801611255565b01949350505050565b6001600160a01b03858116825284166020820152604081018390526080606082018190525f906115e090830184611277565b9695505050505050565b5f602082840312156115fa575f80fd5b8151610a028161122556fea26469706673582212201a2bff33feee5e186992d39aa788675d063004dcdadd758287390d5777fc39c964736f6c63430008140033";
        public NFTPatientHealthChainDeploymentBase() : base(BYTECODE) { }
        public NFTPatientHealthChainDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_myTokenAddress", 1)]
        public virtual string MyTokenAddress { get; set; }
        [Parameter("address", "initialOwner", 2)]
        public virtual string InitialOwner { get; set; }
        [Parameter("address", "_housewallet", 3)]
        public virtual string Housewallet { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class GetApprovedFunction : GetApprovedFunctionBase { }

    [Function("getApproved", "address")]
    public class GetApprovedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetTransactionStatusFunction : GetTransactionStatusFunctionBase { }

    [Function("getTransactionStatus", "bool")]
    public class GetTransactionStatusFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "txHash", 1)]
        public virtual byte[] TxHash { get; set; }
    }

    public partial class HousewalletFunction : HousewalletFunctionBase { }

    [Function("housewallet", "address")]
    public class HousewalletFunctionBase : FunctionMessage
    {

    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class MarkTransactionCompletedFunction : MarkTransactionCompletedFunctionBase { }

    [Function("markTransactionCompleted")]
    public class MarkTransactionCompletedFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "txHash", 1)]
        public virtual byte[] TxHash { get; set; }
    }

    public partial class MintNFTFunction : MintNFTFunctionBase { }

    [Function("mintNFT")]
    public class MintNFTFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class MyTokenFunction : MyTokenFunctionBase { }

    [Function("myToken", "address")]
    public class MyTokenFunctionBase : FunctionMessage
    {

    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class SafeTransferFrom1Function : SafeTransferFrom1FunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFrom1FunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferNFTFunction : TransferNFTFunctionBase { }

    [Function("transferNFT")]
    public class TransferNFTFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferNFTWithTokenFunction : TransferNFTWithTokenFunctionBase { }

    [Function("transferNFTWithToken", "bytes32")]
    public class TransferNFTWithTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "tokenAmount", 3)]
        public virtual BigInteger TokenAmount { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "approved", 2, true )]
        public virtual string Approved { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class NFTTransferredEventDTO : NFTTransferredEventDTOBase { }

    [Event("NFTTransferred")]
    public class NFTTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "tokenAmount", 4, false )]
        public virtual BigInteger TokenAmount { get; set; }
        [Parameter("bytes32", "txHash", 5, false )]
        public virtual byte[] TxHash { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ERC721IncorrectOwnerError : ERC721IncorrectOwnerErrorBase { }

    [Error("ERC721IncorrectOwner")]
    public class ERC721IncorrectOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("address", "owner", 3)]
        public virtual string Owner { get; set; }
    }

    public partial class ERC721InsufficientApprovalError : ERC721InsufficientApprovalErrorBase { }

    [Error("ERC721InsufficientApproval")]
    public class ERC721InsufficientApprovalErrorBase : IErrorDTO
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ERC721InvalidApproverError : ERC721InvalidApproverErrorBase { }

    [Error("ERC721InvalidApprover")]
    public class ERC721InvalidApproverErrorBase : IErrorDTO
    {
        [Parameter("address", "approver", 1)]
        public virtual string Approver { get; set; }
    }

    public partial class ERC721InvalidOperatorError : ERC721InvalidOperatorErrorBase { }

    [Error("ERC721InvalidOperator")]
    public class ERC721InvalidOperatorErrorBase : IErrorDTO
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
    }

    public partial class ERC721InvalidOwnerError : ERC721InvalidOwnerErrorBase { }

    [Error("ERC721InvalidOwner")]
    public class ERC721InvalidOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class ERC721InvalidReceiverError : ERC721InvalidReceiverErrorBase { }

    [Error("ERC721InvalidReceiver")]
    public class ERC721InvalidReceiverErrorBase : IErrorDTO
    {
        [Parameter("address", "receiver", 1)]
        public virtual string Receiver { get; set; }
    }

    public partial class ERC721InvalidSenderError : ERC721InvalidSenderErrorBase { }

    [Error("ERC721InvalidSender")]
    public class ERC721InvalidSenderErrorBase : IErrorDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class ERC721NonexistentTokenError : ERC721NonexistentTokenErrorBase { }

    [Error("ERC721NonexistentToken")]
    public class ERC721NonexistentTokenErrorBase : IErrorDTO
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class OwnableInvalidOwnerError : OwnableInvalidOwnerErrorBase { }

    [Error("OwnableInvalidOwner")]
    public class OwnableInvalidOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class OwnableUnauthorizedAccountError : OwnableUnauthorizedAccountErrorBase { }

    [Error("OwnableUnauthorizedAccount")]
    public class OwnableUnauthorizedAccountErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetApprovedOutputDTO : GetApprovedOutputDTOBase { }

    [FunctionOutput]
    public class GetApprovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetTransactionStatusOutputDTO : GetTransactionStatusOutputDTOBase { }

    [FunctionOutput]
    public class GetTransactionStatusOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class HousewalletOutputDTO : HousewalletOutputDTOBase { }

    [FunctionOutput]
    public class HousewalletOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class MyTokenOutputDTO : MyTokenOutputDTOBase { }

    [FunctionOutput]
    public class MyTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }









    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }








}
