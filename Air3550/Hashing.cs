/*
 Air 3550 Project Team 7

This program is a basic flight reservation system for a fake airline company
It allows customers to book, manage, cancel, and browse flights within a database.
It also allows employee accounts to update and manage flights and view business statistics.

Written by: Harrison Kania, Tyler Ehlert, Daniel Wellons
For EECS3550-001 Software Engineering, Instructor: Dr. Thomas 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    public enum Supported_HA
    {
        SHA256, SHA384, SHA512
    }
    //hashing class to store the password for the customerm supporst SHA512 format
    class Hashing
    {
        public static string ComputeHash(string plainText, Supported_HA hash, byte[] salt)
        {
            int minSaltLength = 4;
            int maxSaltLength = 16;

            byte[] SaltBytes = null;

            if (salt != null)
            {
                SaltBytes = salt;
            }
            else
            {
                Random r = new Random();
                int SaltLength = r.Next(minSaltLength, maxSaltLength);
                SaltBytes = new byte[SaltLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(SaltBytes);
                // if an object is disposable you should dispose of it -- more secure
                rng.Dispose();
            }

            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(plainText);
            byte[] plainDataAndSalt = new byte[plainData.Length + SaltBytes.Length];

            // keep x within the boundaries of the array 
            for (int x = 0; x < plainData.Length; x++)
            {
                plainDataAndSalt[x] = plainData[x];
            }
            for (int n = 0; n < SaltBytes.Length; n++)
            {
                plainDataAndSalt[plainData.Length + n] = SaltBytes[n];
            }

            byte[] hashValue = null;

            switch (hash)
            {
                case Supported_HA.SHA256:
                    SHA256Managed sha256 = new SHA256Managed();
                    hashValue = sha256.ComputeHash(plainDataAndSalt);
                    sha256.Dispose();
                    break;

                case Supported_HA.SHA384:
                    SHA384Managed sha384 = new SHA384Managed();
                    hashValue = sha384.ComputeHash(plainDataAndSalt);
                    sha384.Dispose();
                    break;

                case Supported_HA.SHA512:
                    SHA512Managed sha512 = new SHA512Managed();
                    hashValue = sha512.ComputeHash(plainDataAndSalt);
                    sha512.Dispose();
                    break;
            }

            byte[] result = new byte[hashValue.Length + SaltBytes.Length];

            for (int x = 0; x < hashValue.Length; x++)
            {
                result[x] = hashValue[x];
            }
            for (int n = 0; n < SaltBytes.Length; n++)
            {
                result[hashValue.Length + n] = SaltBytes[n];
            }

            return Convert.ToBase64String(result);
        }

        public static bool Confirm(string plainText, string hashValue, Supported_HA hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hashValue);

            int hashSize = 0;

            switch (hash)
            {
                case Supported_HA.SHA256:
                    hashSize = 32;
                    break;
                case Supported_HA.SHA384:
                    hashSize = 48;
                    break;
                case Supported_HA.SHA512:
                    hashSize = 64;
                    break;
            }

            byte[] saltBytes = new byte[hashBytes.Length - hashSize];

            for (int x = 0; x < saltBytes.Length; x++)
            {
                saltBytes[x] = hashBytes[hashSize + x];
            }

            string newHash = ComputeHash(plainText, hash, saltBytes);

            return (hashValue == newHash);
        }
    }
}
