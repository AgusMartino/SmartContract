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
        public static string BYTECODE = "608060405234801562000010575f80fd5b50604051620018b2380380620018b283398101604081905262000033916200014e565b806040518060400160405280600a81526020016913919514185d1a595b9d60b21b815250604051806040016040528060048152602001631394139560e21b815250815f90816200008491906200021d565b5060016200009382826200021d565b5050506001600160a01b038116620000c457604051631e4fbdf760e01b81525f600482015260240160405180910390fd5b620000cf81620000fd565b5050600780546001600160a01b0319167375644b22c8ea18657852cd4931de377332e1220d179055620002e5565b600680546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0905f90a35050565b5f602082840312156200015f575f80fd5b81516001600160a01b038116811462000176575f80fd5b9392505050565b634e487b7160e01b5f52604160045260245ffd5b600181811c90821680620001a657607f821691505b602082108103620001c557634e487b7160e01b5f52602260045260245ffd5b50919050565b601f82111562000218575f81815260208120601f850160051c81016020861015620001f35750805b601f850160051c820191505b818110156200021457828155600101620001ff565b5050505b505050565b81516001600160401b038111156200023957620002396200017d565b62000251816200024a845462000191565b84620001cb565b602080601f83116001811462000287575f84156200026f5750858301515b5f19600386901b1c1916600185901b17855562000214565b5f85815260208120601f198616915b82811015620002b75788860151825594840194600190910190840162000296565b5085821015620002d557878501515f19600388901b60f8161c191681555b5050505050600190811b01905550565b6115bf80620002f35f395ff3fe60806040526004361061013c575f3560e01c806370a08231116100b357806395d89b411161006d57806395d89b4114610379578063a22cb4651461038d578063b88d4fde146103ac578063c87b56dd146103cb578063e985e9c5146103ea578063f2fde38b14610409575f80fd5b806370a08231146102bd578063715018a6146102dc578063863b3894146102f05780638da5cb5b1461030f578063944074651461032c57806394ab67fe1461035a575f80fd5b80633741897211610104578063374189721461020c5780633c168eab1461022b57806342842e0e1461024a5780635c91eeaa146102695780635fd8c7101461028a5780636352211e1461029e575f80fd5b806301ffc9a71461014057806306fdde0314610174578063081812fc14610195578063095ea7b3146101cc57806323b872dd146101ed575b5f80fd5b34801561014b575f80fd5b5061015f61015a366004611212565b610428565b60405190151581526020015b60405180910390f35b34801561017f575f80fd5b50610188610479565b60405161016b919061127a565b3480156101a0575f80fd5b506101b46101af36600461128c565b610508565b6040516001600160a01b03909116815260200161016b565b3480156101d7575f80fd5b506101eb6101e63660046112be565b61052f565b005b3480156101f8575f80fd5b506101eb6102073660046112e6565b61053e565b348015610217575f80fd5b506101eb61022636600461128c565b6105cc565b348015610236575f80fd5b506101eb6102453660046112be565b6105ee565b348015610255575f80fd5b506101eb6102643660046112e6565b610679565b61027c6102773660046112be565b610698565b60405190815260200161016b565b348015610295575f80fd5b506101eb610812565b3480156102a9575f80fd5b506101b46102b836600461128c565b610853565b3480156102c8575f80fd5b5061027c6102d736600461131f565b61085d565b3480156102e7575f80fd5b506101eb6108a2565b3480156102fb575f80fd5b506007546101b4906001600160a01b031681565b34801561031a575f80fd5b506006546001600160a01b03166101b4565b348015610337575f80fd5b5061015f61034636600461128c565b5f9081526009602052604090205460ff1690565b348015610365575f80fd5b506101eb6103743660046112be565b6108b5565b348015610384575f80fd5b50610188610942565b348015610398575f80fd5b506101eb6103a7366004611338565b610951565b3480156103b7575f80fd5b506101eb6103c6366004611385565b61095c565b3480156103d6575f80fd5b506101886103e536600461128c565b610973565b3480156103f5575f80fd5b5061015f61040436600461145a565b6109e4565b348015610414575f80fd5b506101eb61042336600461131f565b610a11565b5f6001600160e01b031982166380ac58cd60e01b148061045857506001600160e01b03198216635b5e139f60e01b145b8061047357506301ffc9a760e01b6001600160e01b03198316145b92915050565b60605f80546104879061148b565b80601f01602080910402602001604051908101604052809291908181526020018280546104b39061148b565b80156104fe5780601f106104d5576101008083540402835291602001916104fe565b820191905f5260205f20905b8154815290600101906020018083116104e157829003601f168201915b5050505050905090565b5f61051282610a4b565b505f828152600460205260409020546001600160a01b0316610473565b61053a828233610a83565b5050565b6001600160a01b03821661056c57604051633250574960e11b81525f60048201526024015b60405180910390fd5b5f610578838333610a90565b9050836001600160a01b0316816001600160a01b0316146105c6576040516364283d7b60e01b81526001600160a01b0380861660048301526024820184905282166044820152606401610563565b50505050565b6105d4610b82565b5f908152600960205260409020805460ff19166001179055565b6105f6610b82565b5f8181526008602052604090205460ff16156106545760405162461bcd60e51b815260206004820152601f60248201527f4e46542077697468207468697320494420616c726561647920657869737473006044820152606401610563565b61065e8282610baf565b5f908152600860205260409020805460ff1916600117905550565b61069383838360405180602001604052805f81525061095c565b505050565b5f806106a383610853565b90506001600160a01b03811633146106cd5760405162461bcd60e51b8152600401610563906114c3565b5f341161071c5760405162461bcd60e51b815260206004820181905260248201527f4554482076616c7565206d7573742062652067726561746572207468616e20306044820152606401610563565b610727818585610c10565b6040516001600160a01b038216903480156108fc02915f818181858888f19350505050158015610759573d5f803e3d5ffd5b506040516bffffffffffffffffffffffff1933606090811b8216602084015286901b166034820152604881018490523460688201524360888201525f9060a80160408051808303601f1901815282825280516020918201205f81815260098352839020805460ff1916905587845290830181905292506001600160a01b0387811692908516917f6ce7a869aeca298d0f3bdbf430acb6be50c36c199a39e377226041328c95352f910160405180910390a3949350505050565b61081a610b82565b6006546040516001600160a01b03909116904780156108fc02915f818181858888f19350505050158015610850573d5f803e3d5ffd5b50565b5f61047382610a4b565b5f6001600160a01b038216610887576040516322718ad960e21b81525f6004820152602401610563565b506001600160a01b03165f9081526003602052604090205490565b6108aa610b82565b6108b35f610cbd565b565b5f6108bf82610853565b90506001600160a01b03811633146108e95760405162461bcd60e51b8152600401610563906114c3565b6108f4818484610c10565b604080518381525f60208201526001600160a01b0380861692908416917f6ce7a869aeca298d0f3bdbf430acb6be50c36c199a39e377226041328c95352f91015b60405180910390a3505050565b6060600180546104879061148b565b61053a338383610d0e565b61096784848461053e565b6105c684848484610da4565b606061097e82610a4b565b505f61099460408051602081019091525f815290565b90505f8151116109b25760405180602001604052805f8152506109dd565b806109bc84610eca565b6040516020016109cd929190611504565b6040516020818303038152906040525b9392505050565b6001600160a01b039182165f90815260056020908152604080832093909416825291909152205460ff1690565b610a19610b82565b6001600160a01b038116610a4257604051631e4fbdf760e01b81525f6004820152602401610563565b61085081610cbd565b5f818152600260205260408120546001600160a01b03168061047357604051637e27328960e01b815260048101849052602401610563565b6106938383836001610f5a565b5f828152600260205260408120546001600160a01b0390811690831615610abc57610abc81848661105e565b6001600160a01b03811615610af657610ad75f855f80610f5a565b6001600160a01b0381165f90815260036020526040902080545f190190555b6001600160a01b03851615610b24576001600160a01b0385165f908152600360205260409020805460010190555b5f8481526002602052604080822080546001600160a01b0319166001600160a01b0389811691821790925591518793918516917fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef91a4949350505050565b6006546001600160a01b031633146108b35760405163118cdaa760e01b8152336004820152602401610563565b6001600160a01b038216610bd857604051633250574960e11b81525f6004820152602401610563565b5f610be483835f610a90565b90506001600160a01b03811615610693576040516339e3563760e11b81525f6004820152602401610563565b6001600160a01b038216610c3957604051633250574960e11b81525f6004820152602401610563565b5f610c4583835f610a90565b90506001600160a01b038116610c7157604051637e27328960e01b815260048101839052602401610563565b836001600160a01b0316816001600160a01b0316146105c6576040516364283d7b60e01b81526001600160a01b0380861660048301526024820184905282166044820152606401610563565b600680546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0905f90a35050565b6001600160a01b038216610d4057604051630b61174360e31b81526001600160a01b0383166004820152602401610563565b6001600160a01b038381165f81815260056020908152604080832094871680845294825291829020805460ff191686151590811790915591519182527f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c319101610935565b6001600160a01b0383163b156105c657604051630a85bd0160e11b81526001600160a01b0384169063150b7a0290610de6903390889087908790600401611532565b6020604051808303815f875af1925050508015610e20575060408051601f3d908101601f19168201909252610e1d9181019061156e565b60015b610e87573d808015610e4d576040519150601f19603f3d011682016040523d82523d5f602084013e610e52565b606091505b5080515f03610e7f57604051633250574960e11b81526001600160a01b0385166004820152602401610563565b805181602001fd5b6001600160e01b03198116630a85bd0160e11b14610ec357604051633250574960e11b81526001600160a01b0385166004820152602401610563565b5050505050565b60605f610ed6836110c2565b60010190505f8167ffffffffffffffff811115610ef557610ef5611371565b6040519080825280601f01601f191660200182016040528015610f1f576020820181803683370190505b5090508181016020015b5f19016f181899199a1a9b1b9c1cb0b131b232b360811b600a86061a8153600a8504945084610f2957509392505050565b8080610f6e57506001600160a01b03821615155b1561102f575f610f7d84610a4b565b90506001600160a01b03831615801590610fa95750826001600160a01b0316816001600160a01b031614155b8015610fbc5750610fba81846109e4565b155b15610fe55760405163a9fbf51f60e01b81526001600160a01b0384166004820152602401610563565b811561102d5783856001600160a01b0316826001600160a01b03167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b92560405160405180910390a45b505b50505f90815260046020526040902080546001600160a01b0319166001600160a01b0392909216919091179055565b611069838383611199565b610693576001600160a01b03831661109757604051637e27328960e01b815260048101829052602401610563565b60405163177e802f60e01b81526001600160a01b038316600482015260248101829052604401610563565b5f8072184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b83106111005772184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b830492506040015b6d04ee2d6d415b85acef8100000000831061112c576d04ee2d6d415b85acef8100000000830492506020015b662386f26fc10000831061114a57662386f26fc10000830492506010015b6305f5e1008310611162576305f5e100830492506008015b612710831061117657612710830492506004015b60648310611188576064830492506002015b600a83106104735760010192915050565b5f6001600160a01b038316158015906111f55750826001600160a01b0316846001600160a01b031614806111d257506111d284846109e4565b806111f557505f828152600460205260409020546001600160a01b038481169116145b949350505050565b6001600160e01b031981168114610850575f80fd5b5f60208284031215611222575f80fd5b81356109dd816111fd565b5f5b8381101561124757818101518382015260200161122f565b50505f910152565b5f815180845261126681602086016020860161122d565b601f01601f19169290920160200192915050565b602081525f6109dd602083018461124f565b5f6020828403121561129c575f80fd5b5035919050565b80356001600160a01b03811681146112b9575f80fd5b919050565b5f80604083850312156112cf575f80fd5b6112d8836112a3565b946020939093013593505050565b5f805f606084860312156112f8575f80fd5b611301846112a3565b925061130f602085016112a3565b9150604084013590509250925092565b5f6020828403121561132f575f80fd5b6109dd826112a3565b5f8060408385031215611349575f80fd5b611352836112a3565b915060208301358015158114611366575f80fd5b809150509250929050565b634e487b7160e01b5f52604160045260245ffd5b5f805f8060808587031215611398575f80fd5b6113a1856112a3565b93506113af602086016112a3565b925060408501359150606085013567ffffffffffffffff808211156113d2575f80fd5b818701915087601f8301126113e5575f80fd5b8135818111156113f7576113f7611371565b604051601f8201601f19908116603f0116810190838211818310171561141f5761141f611371565b816040528281528a6020848701011115611437575f80fd5b826020860160208301375f60208483010152809550505050505092959194509250565b5f806040838503121561146b575f80fd5b611474836112a3565b9150611482602084016112a3565b90509250929050565b600181811c9082168061149f57607f821691505b6020821081036114bd57634e487b7160e01b5f52602260045260245ffd5b50919050565b60208082526021908201527f596f7520617265206e6f7420746865206f776e6572206f662074686973204e466040820152601560fa1b606082015260800190565b5f835161151581846020880161122d565b83519083019061152981836020880161122d565b01949350505050565b6001600160a01b03858116825284166020820152604081018390526080606082018190525f906115649083018461124f565b9695505050505050565b5f6020828403121561157e575f80fd5b81516109dd816111fd56fea26469706673582212206e3c1a7095be0e5641e6a44dcf20d6e35a1c37aa49fb765153f81b5f217e2ef564736f6c63430008150033";
        public NFTPatientHealthChainDeploymentBase() : base(BYTECODE) { }
        public NFTPatientHealthChainDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "initialOwner", 1)]
        public virtual string InitialOwner { get; set; }
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

    public partial class TransferNFTWithETHFunction : TransferNFTWithETHFunctionBase { }

    [Function("transferNFTWithETH", "bytes32")]
    public class TransferNFTWithETHFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class WithdrawBalanceFunction : WithdrawBalanceFunctionBase { }

    [Function("withdrawBalance")]
    public class WithdrawBalanceFunctionBase : FunctionMessage
    {

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
        [Parameter("bytes32", "txHash", 4, false )]
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
