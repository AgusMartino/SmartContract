// SPDX-License-Identifier: MIT
pragma solidity >=0.4.0 <0.9.0;

import "@openzeppelin/contracts/token/ERC721/ERC721.sol";
import "@openzeppelin/contracts/access/Ownable.sol";
import "@openzeppelin/contracts/token/ERC20/IERC20.sol";

contract NFTPatientHealthChain is ERC721, Ownable {
    IERC20 public myToken; // Contrato del token ERC-20 "HealthChain"
    address public housewallet;

    // Mapping para llevar un registro de los IDs de los NFTs existentes
    mapping(uint256 => bool) private _nftExists;
    mapping(bytes32 => bool) private _completedTransactions;

    // Evento para registrar información sobre las transacciones
    event NFTTransferred(address indexed from, address indexed to, uint256 tokenId, uint256 tokenAmount, bytes32 txHash);

    constructor(address _myTokenAddress, address initialOwner, address _housewallet) ERC721("NFTPatient", "NPNT") Ownable(initialOwner) {
        myToken = IERC20(_myTokenAddress);
        housewallet = _housewallet;
    }

    // Función para crear un nuevo NFT con un ID específico
    function mintNFT(address to, uint256 tokenId) public onlyOwner {
        require(!_nftExists[tokenId], "NFT with this ID already exists");

        _mint(to, tokenId);
        _nftExists[tokenId] = true;
    }

    // Función para transferir un NFT de forma gratuita a una dirección (solo puede hacerlo el propietario del NFT)
    function transferNFT(address to, uint256 tokenId) public {
        address owner = ownerOf(tokenId);
        require(owner == msg.sender, "You are not the owner of this NFT");
        _transfer(owner, to, tokenId);
        // Emitir el evento de transferencia de NFT con tokens
        emit NFTTransferred(owner, to, tokenId, 0, bytes32(0));
    }

    // Función para transferir un NFT a una dirección y pagar con el token ERC-20 "HealthChain"
    function transferNFTWithToken(address to, uint256 tokenId, uint256 tokenAmount) public payable returns (bytes32) {
        // owner = medico (vendedor)
        // to = prepaga (comprador)
        address owner = ownerOf(tokenId);
        require(owner == msg.sender, "You are not the owner of this NFT");

        // Transfiere el NFT al destinatario
        _transfer(owner, to, tokenId);

        // Realiza la transferencia de tokens amount ERC-20 "HealthChain"
        require(myToken.transferFrom(to, owner, tokenAmount), "Token Amount transfer failed");

        // Obtener el ID de transacción actual
        bytes32 txHash = keccak256(abi.encodePacked(msg.sender, to, tokenId, tokenAmount, block.number));

        // Registrar la transacción como pendiente
        _completedTransactions[txHash] = false;

        // Emitir el evento de transferencia de NFT con tokens
        emit NFTTransferred(owner, to, tokenId, tokenAmount, txHash);

        return txHash; // Devolver el ID de transacción
    }

    // Función para consultar el estado de una transacción por su ID de transacción
    function getTransactionStatus(bytes32 txHash) public view returns (bool) {
        // Verificar si la transacción se ha completado (incluida en un bloque)
        return _completedTransactions[txHash];
    }

    // Función para marcar una transacción como completada (solo para el propietario)
    function markTransactionCompleted(bytes32 txHash) public onlyOwner {
        _completedTransactions[txHash] = true;
    }
}