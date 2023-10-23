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

namespace SmartContract.Contracts.HealthChain.ContractDefinition
{


    public partial class HealthChainDeployment : HealthChainDeploymentBase
    {
        public HealthChainDeployment() : base(BYTECODE) { }
        public HealthChainDeployment(string byteCode) : base(byteCode) { }
    }

    public class HealthChainDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801562000010575f80fd5b506040518060400160405280600b81526020016a2432b0b63a3421b430b4b760a91b81525060405180604001604052806003815260200162484c4360e81b8152508160039081620000629190620002a4565b506004620000718282620002a4565b506a52b7d2dcc80cd2e400000091506200008e9050338262000095565b5062000392565b6001600160a01b038216620000c45760405163ec442f0560e01b81525f60048201526024015b60405180910390fd5b620000d15f8383620000d5565b5050565b6001600160a01b03831662000103578060025f828254620000f791906200036c565b90915550620001759050565b6001600160a01b0383165f9081526020819052604090205481811015620001575760405163391434e360e21b81526001600160a01b03851660048201526024810182905260448101839052606401620000bb565b6001600160a01b0384165f9081526020819052604090209082900390555b6001600160a01b0382166200019357600280548290039055620001b1565b6001600160a01b0382165f9081526020819052604090208054820190555b816001600160a01b0316836001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef83604051620001f791815260200190565b60405180910390a3505050565b634e487b7160e01b5f52604160045260245ffd5b600181811c908216806200022d57607f821691505b6020821081036200024c57634e487b7160e01b5f52602260045260245ffd5b50919050565b601f8211156200029f575f81815260208120601f850160051c810160208610156200027a5750805b601f850160051c820191505b818110156200029b5782815560010162000286565b5050505b505050565b81516001600160401b03811115620002c057620002c062000204565b620002d881620002d1845462000218565b8462000252565b602080601f8311600181146200030e575f8415620002f65750858301515b5f19600386901b1c1916600185901b1785556200029b565b5f85815260208120601f198616915b828110156200033e578886015182559484019460019091019084016200031d565b50858210156200035c57878501515f19600388901b60f8161c191681555b5050505050600190811b01905550565b808201808211156200038c57634e487b7160e01b5f52601160045260245ffd5b92915050565b61073280620003a05f395ff3fe608060405234801561000f575f80fd5b506004361061009b575f3560e01c806370a082311161006357806370a082311461011457806371d2b9871461013c57806395d89b4114610151578063a9059cbb14610159578063dd62ed3e1461016c575f80fd5b806306fdde031461009f578063095ea7b3146100bd57806318160ddd146100e057806323b872dd146100f2578063313ce56714610105575b5f80fd5b6100a76101a4565b6040516100b4919061058d565b60405180910390f35b6100d06100cb3660046105f3565b610234565b60405190151581526020016100b4565b6002545b6040519081526020016100b4565b6100d061010036600461061b565b61024d565b604051601281526020016100b4565b6100e4610122366004610654565b6001600160a01b03165f9081526020819052604090205490565b61014f61014a366004610654565b610270565b005b6100a761028a565b6100d06101673660046105f3565b610299565b6100e461017a366004610674565b6001600160a01b039182165f90815260016020908152604080832093909416825291909152205490565b6060600380546101b3906106a5565b80601f01602080910402602001604051908101604052809291908181526020018280546101df906106a5565b801561022a5780601f106102015761010080835404028352916020019161022a565b820191905f5260205f20905b81548152906001019060200180831161020d57829003601f168201915b5050505050905090565b5f336102418185856102a6565b60019150505b92915050565b5f3361025a8582856102b8565b610265858585610338565b506001949350505050565b690a968163f0a57b400000610286338383610338565b5050565b6060600480546101b3906106a5565b5f33610241818585610338565b6102b38383836001610395565b505050565b6001600160a01b038381165f908152600160209081526040808320938616835292905220545f198114610332578181101561032457604051637dc7a0d960e11b81526001600160a01b038416600482015260248101829052604481018390526064015b60405180910390fd5b61033284848484035f610395565b50505050565b6001600160a01b03831661036157604051634b637e8f60e11b81525f600482015260240161031b565b6001600160a01b03821661038a5760405163ec442f0560e01b81525f600482015260240161031b565b6102b3838383610467565b6001600160a01b0384166103be5760405163e602df0560e01b81525f600482015260240161031b565b6001600160a01b0383166103e757604051634a1406b160e11b81525f600482015260240161031b565b6001600160a01b038085165f908152600160209081526040808320938716835292905220829055801561033257826001600160a01b0316846001600160a01b03167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b9258460405161045991815260200190565b60405180910390a350505050565b6001600160a01b038316610491578060025f82825461048691906106dd565b909155506105019050565b6001600160a01b0383165f90815260208190526040902054818110156104e35760405163391434e360e21b81526001600160a01b0385166004820152602481018290526044810183905260640161031b565b6001600160a01b0384165f9081526020819052604090209082900390555b6001600160a01b03821661051d5760028054829003905561053b565b6001600160a01b0382165f9081526020819052604090208054820190555b816001600160a01b0316836001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef8360405161058091815260200190565b60405180910390a3505050565b5f6020808352835180828501525f5b818110156105b85785810183015185820160400152820161059c565b505f604082860101526040601f19601f8301168501019250505092915050565b80356001600160a01b03811681146105ee575f80fd5b919050565b5f8060408385031215610604575f80fd5b61060d836105d8565b946020939093013593505050565b5f805f6060848603121561062d575f80fd5b610636846105d8565b9250610644602085016105d8565b9150604084013590509250925092565b5f60208284031215610664575f80fd5b61066d826105d8565b9392505050565b5f8060408385031215610685575f80fd5b61068e836105d8565b915061069c602084016105d8565b90509250929050565b600181811c908216806106b957607f821691505b6020821081036106d757634e487b7160e01b5f52602260045260245ffd5b50919050565b8082018082111561024757634e487b7160e01b5f52601160045260245ffdfea2646970667358221220e2aa120a3b2744891d8583ae973f6ee612ae43f027f9ec987b9b762f07ed611b64736f6c63430008140033";
        public HealthChainDeploymentBase() : base(BYTECODE) { }
        public HealthChainDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 2)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 2)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferToAddressFunction : TransferToAddressFunctionBase { }

    [Function("transferToAddress")]
    public class TransferToAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "recipient", 1)]
        public virtual string Recipient { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true )]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class ERC20InsufficientAllowanceError : ERC20InsufficientAllowanceErrorBase { }

    [Error("ERC20InsufficientAllowance")]
    public class ERC20InsufficientAllowanceErrorBase : IErrorDTO
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "allowance", 2)]
        public virtual BigInteger Allowance { get; set; }
        [Parameter("uint256", "needed", 3)]
        public virtual BigInteger Needed { get; set; }
    }

    public partial class ERC20InsufficientBalanceError : ERC20InsufficientBalanceErrorBase { }

    [Error("ERC20InsufficientBalance")]
    public class ERC20InsufficientBalanceErrorBase : IErrorDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("uint256", "balance", 2)]
        public virtual BigInteger Balance { get; set; }
        [Parameter("uint256", "needed", 3)]
        public virtual BigInteger Needed { get; set; }
    }

    public partial class ERC20InvalidApproverError : ERC20InvalidApproverErrorBase { }

    [Error("ERC20InvalidApprover")]
    public class ERC20InvalidApproverErrorBase : IErrorDTO
    {
        [Parameter("address", "approver", 1)]
        public virtual string Approver { get; set; }
    }

    public partial class ERC20InvalidReceiverError : ERC20InvalidReceiverErrorBase { }

    [Error("ERC20InvalidReceiver")]
    public class ERC20InvalidReceiverErrorBase : IErrorDTO
    {
        [Parameter("address", "receiver", 1)]
        public virtual string Receiver { get; set; }
    }

    public partial class ERC20InvalidSenderError : ERC20InvalidSenderErrorBase { }

    [Error("ERC20InvalidSender")]
    public class ERC20InvalidSenderErrorBase : IErrorDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class ERC20InvalidSpenderError : ERC20InvalidSpenderErrorBase { }

    [Error("ERC20InvalidSpender")]
    public class ERC20InvalidSpenderErrorBase : IErrorDTO
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }






}
