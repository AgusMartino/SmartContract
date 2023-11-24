// SPDX-License-Identifier: MIT
pragma solidity >=0.4.0 <0.9.0;

import "@openzeppelin/contracts/token/ERC721/ERC721.sol";
import "@openzeppelin/contracts/access/Ownable.sol";

contract NFTPatientHealthChain is ERC721, Ownable {
    address public housewallet;

    // Mapping para llevar un registro de los IDs de los NFTs existentes
    mapping(uint256 => bool) private _nftExists;
    mapping(bytes32 => bool) private _completedTransactions;

    // Evento para registrar información sobre las transacciones
    event NFTTransferred(address indexed from, address indexed to, uint256 tokenId, bytes32 txHash);

    constructor(address initialOwner) ERC721("NFTPatient", "NPNT") Ownable(initialOwner) {
        housewallet = initialOwner;
    }

    // Función para crear un nuevo NFT con un ID específico
    function mintNFT(address to, uint256 tokenId) public {
        require(!_nftExists[tokenId], "NFT with this ID already exists");

        _mint(to, tokenId);
        _nftExists[tokenId] = true;
    }

    // Función para transferir un NFT de forma gratuita a una dirección (solo puede hacerlo el propietario del NFT)
    function transferNFT(address to, uint256 tokenId) public {
        address owner = ownerOf(tokenId);
        require(owner == msg.sender, "You are not the owner of this NFT");
        _transfer(owner, to, tokenId);
        // Emitir el evento de transferencia de NFT
        emit NFTTransferred(owner, to, tokenId, bytes32(0));
    }

    // Función para transferir un NFT a una dirección y pagar con ETH
    function transferNFTWithETH(address to, uint256 tokenId) public payable returns (bytes32) {
        address owner = ownerOf(tokenId);
        require(owner == msg.sender, "You are not the owner of this NFT");
        require(msg.value > 0, "ETH value must be greater than 0"); // Verificar que se haya enviado ETH

        // Transfiere el NFT al destinatario
        _transfer(owner, to, tokenId);

        // Transferir el ETH al propietario del NFT
        payable(owner).transfer(msg.value);

        // Obtener el ID de transacción actual
        bytes32 txHash = keccak256(abi.encodePacked(msg.sender, to, tokenId, msg.value, block.number));

        // Registrar la transacción como pendiente
        _completedTransactions[txHash] = false;

        // Emitir el evento de transferencia de NFT con ETH
        emit NFTTransferred(owner, to, tokenId, txHash);

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

    // Función para retirar el saldo de ETH en el contrato (solo para el propietario)
    function withdrawBalance() public onlyOwner {
        payable(owner()).transfer(address(this).balance);
    }
}